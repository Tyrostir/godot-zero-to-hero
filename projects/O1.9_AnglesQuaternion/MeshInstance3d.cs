using Godot;
using System;

public partial class MeshInstance3d : MeshInstance3D
{
	[Export] public Node3D Target { get; set; }
	[Export] public bool Smooth { get; set; } = true;
	[Export(PropertyHint.Range, "0.5,20,0.5")] public float TurnSpeed { get; set; } = 5f;
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		DebugDraw3D.DrawLine(GlobalPosition,
							 GlobalPosition - GlobalTransform.Basis.Z * 2f,
							 Colors.Yellow);
		//RotateY(Mathf.DegToRad(60) * (float) delta);
		
		if (Target is null) return;
		
		if (!Smooth)
		{
			LookAt(Target.GlobalPosition, Vector3.Up);      // snap
			return;
		}
		
		// The orientation LookAt WOULD give us...
		Transform3D want = GlobalTransform.LookingAt(Target.GlobalPosition, Vector3.Up);

		// ...approached along the shortest arc.
		Quaternion current = GlobalBasis.GetRotationQuaternion();
		Quaternion desired = want.Basis.GetRotationQuaternion();

		float t = 1f - Mathf.Exp(-TurnSpeed * (float)delta);   // framerate-independent
		GlobalBasis = new Basis(current.Slerp(desired, t));
		
	}
}

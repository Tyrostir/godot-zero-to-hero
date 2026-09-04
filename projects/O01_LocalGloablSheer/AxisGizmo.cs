using Godot;
using System;

public partial class AxisGizmo : Node3D
{
	[Export] public bool ReportOnReady {get;set;} = true;
	[Export] public bool SnapToWorldOrigin { get; set; } = false;
	 [Export] public bool UseLocalTranslate { get; set; } = false;
	[Export] public bool DriveForward {get;set;} = false;
	[Export(PropertyHint.Range, "0,10,0.1")] public float Speed {get;set;} = 2;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		if (!ReportOnReady) return;

		GD.Print($"--- {Name} ---");
		GD.Print($"  Position       = {Position}");
		GD.Print($"  GlobalPosition = {GlobalPosition}");
		GD.Print($"  Rotation°      = {RotationDegrees}");
		GD.Print($"  GlobalRotation°= {GlobalRotationDegrees}");
		GD.Print($"  forward (-Z)   = {-GlobalTransform.Basis.Z}");
	}


	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if (SnapToWorldOrigin)
		{
			SnapToWorldOrigin = false;
			//GlobalPosition = new Vector3(0, 2, 0);       // I want it HERE, in the world
			//GD.Print($"  after: Position={Position}  GlobalPosition={GlobalPosition}");
			PlaceLookingAt(new Vector3(0,0,0), new Vector3(5, 10, 0));
		}
		
		if (!DriveForward) return;
		float step = Speed * (float)delta;

		if (UseLocalTranslate)
			TranslateObjectLocal(Vector3.Forward * step);   // along ITS OWN forward
		else
			GlobalTranslate(Vector3.Forward * step);        // along the WORLD's forward
	}
	
	public void PlaceLookingAt(Vector3 where, Vector3 target)
	{
		GlobalTransform = new Transform3D(Basis.Identity, where)
			.LookingAt(target, Vector3.Up);
	}
}

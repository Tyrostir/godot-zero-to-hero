using Godot;
using System;

public partial class AxisGizmo : Node3D
{
	[Export] public bool ReportOnReady { get; set; } = true;
	 [Export] public bool DriveForward { get; set; } = false;
	[Export(PropertyHint.Range, "0,10,0.1")] public float Speed { get; set; } = 2f;
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		if (!ReportOnReady) return;
		
		Basis b = GlobalTransform.Basis;
		GD.Print($"--- {Name} ---");
		GD.Print($"  position     = {GlobalPosition}");
		GD.Print($"  transform    = {GlobalTransform}");
		GD.Print($"  right   (+X) = {b.X}");
		GD.Print($"  up      (+Y) = {b.Y}");
		GD.Print($"  back    (+Z) = {b.Z}");
		GD.Print($"  FORWARD (-Z) = {-b.Z}");
		
		var mesh = GetNode<Node3D>("MeshInstance3D");
		GD.Print($"--- {mesh.Name} ---");
		GD.Print($"  position     = {mesh.GlobalPosition}");
		
		var cam = GetNode<Node3D>("Camera3D");
		GD.Print($"--- {cam.Name} ---");
		GD.Print($"  position     = {cam.GlobalPosition}");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if (!DriveForward) return;

		// Its OWN forward — the third basis column, negated.
		Vector3 forward = -GlobalTransform.Basis.Z;
		GlobalPosition += forward * Speed * (float)delta;
	}
}

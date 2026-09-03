using Godot;
using System;

public partial class spinBad : Node
{
	// ⚠️ deliberately wrong — no delta
	[Export] public float DegreesPerFrame { get; set; } = 1f;

	public override void _PhysicsProcess(double delta)
	{
		var mesh = GetNode<MeshInstance3D>("MeshInstance3D");
		mesh.RotateY(Mathf.DegToRad(DegreesPerFrame));
	}
}

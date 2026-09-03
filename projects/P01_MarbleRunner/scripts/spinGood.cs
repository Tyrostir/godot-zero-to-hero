using Godot;
using System;

public partial class spinGood : Node
{
	[Export] public float DegreesPerSecond { get; set; } = 60f;

	public override void _Process(double delta)
	{
		// a RATE multiplied by TIME gives an AMOUNT
		var mesh = GetNode<MeshInstance3D>("MeshInstance3D");
		GD.Print($"mesh: {Name}");
		mesh.RotateY(Mathf.DegToRad(DegreesPerSecond) * (float)delta);
	}
}

using Godot;
using System;

public partial class Spinner : MeshInstance3D
{
	[Export] public float DegreesPerSecond {get;set;} = 90f;
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		GD.Print($"Hello Phone - running on {OS.GetName()}, {Engine.GetVersionInfo()["string"]}");
		GD.Print($"Spinning at {DegreesPerSecond}°/s.");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		RotateY(Mathf.DegToRad(DegreesPerSecond) * (float) delta);
	}
}

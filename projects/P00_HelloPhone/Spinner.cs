using Godot;
using System;
using Humanizer;

public partial class Spinner : MeshInstance3D
{
	[Export] public float DegreesPerSecond {get;set;} = 90f;
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
							
		GD.Print($"Hello Phone - running on {OS.GetName()}, {Engine.GetVersionInfo()["string"]}");
		GD.Print($"Spinning at {DegreesPerSecond}°/s.");
		
		var mesh = GetNode<MeshInstance3D>(".");
		//var mesh = GetNode<MeshInstance3D>("Cube");
		//GD.Print($"mesh: {mesh}");
		
		var upTime = TimeSpan.FromSeconds(Time.GetTicksMsec() / 1000.0);
		GD.Print($"Humanizer says: {upTime.Humanize()} since start");
		GD.Print($"And {90.ToWords()} degrees per second reads better than 90");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		DebugDraw3D.DrawLine(GlobalPosition,
							 GlobalPosition - GlobalTransform.Basis.Z * 2f,
							 Colors.Yellow);
		RotateY(Mathf.DegToRad(DegreesPerSecond) * (float) delta);
		//var upTime = TimeSpan.FromSeconds(Time.GetTicksMsec() / 1000.0);
		//GD.Print($"Humanizer says: {upTime.Humanize()} since start");
		//GD.Print($"And {90.ToWords()} degrees per second reads better than 90");
	}
}

using Godot;
using System.Collections.Generic;

public partial class FpsSwitcher : Node3D
{
	[Export] public int MaxFps { get; set; } = 0;   // 0 = uncapped

	public override void _Ready()
	{
		Engine.MaxFps = MaxFps;
		GD.Print($"MaxFps = {MaxFps} (0 means uncapped)");
	}
	public override void _Process(double delta)
	{
		// ⚠️ allocates a new object EVERY FRAME
		//var wasteful = new List<int>(1000);
		//wasteful.Add(1);
	}
}

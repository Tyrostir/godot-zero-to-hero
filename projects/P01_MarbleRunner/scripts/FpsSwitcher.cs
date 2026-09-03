using Godot;

public partial class FpsSwitcher : Node3D
{
	[Export] public int MaxFps { get; set; } = 0;   // 0 = uncapped

	public override void _Ready()
	{
		Engine.MaxFps = MaxFps;
		GD.Print($"MaxFps = {MaxFps} (0 means uncapped)");
	}
}

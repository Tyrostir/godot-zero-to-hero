using Godot;

public partial class ShapeStress : Node3D
{
	[Export] public PackedScene BodyScene { get; set; }
	[Export(PropertyHint.Range, "10,1000,10")] public int Count { get; set; } = 200;
	[Export] public bool Spawn { get; set; } = false;

	public override void _Ready()
	{
		GD.Print("Here");
		if (!Spawn || BodyScene is null) return;
		GD.Print("Here2");
		var rng = new RandomNumberGenerator();
		rng.Randomize();

		for (int i = 0; i < Count; i++)
		{
			var b = BodyScene.Instantiate<RigidBody3D>();
			AddChild(b);
			b.GlobalPosition = new Vector3(rng.RandfRange(-5, 5), 5 + i * 0.15f,
										   rng.RandfRange(-5, 5));
		}
		GD.Print($"spawned {Count}");
	}
}

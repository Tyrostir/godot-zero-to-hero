using Godot;

public partial class Marble : RigidBody3D
{
	[Export] public float KillY { get; set; } = -10f;
	[Export] public Vector3 SpawnPoint { get; set; } = new Vector3(0, 5, -6);

	private int _respawns;

	public override void _Ready()
	{
		SpawnPoint = GlobalPosition;     // wherever the designer placed me
		GD.Print($"{Name} spawns at {SpawnPoint}");
	}

	public override void _PhysicsProcess(double delta)
	{
		if (GlobalPosition.Y < KillY)
			Respawn();
	}

	private void Respawn()
	{
		_respawns++;
		GD.Print($"{Name} fell out of the world — respawn #{_respawns}");

		// 🚨 order matters, and so does clearing momentum
		LinearVelocity  = Vector3.Zero;
		AngularVelocity = Vector3.Zero;
		GlobalPosition  = SpawnPoint;
	}
}

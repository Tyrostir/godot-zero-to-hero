using Godot;
using System;

public partial class Marble : RigidBody3D
{
	[ExportGroup("Respawn")]
	[Export(PropertyHint.Range, "-50,0,1")]
	public float KillY { get; set; } = -10f;
	
	[ExportGroup("Drive")]
	[Export] public bool UseImpulse { get; set; } = false;
	[Export(PropertyHint.Range, "0,200,1")] public float Strength { get; set; } = 20f;
	[Export] public bool Fire { get; set; } = false;
	[Export(PropertyHint.Range, "0,100,1")] public float TorqueStrength { get; set; } = 12f;
	
	[ExportGroup("Feel")]
	[Export(PropertyHint.Range, "0,10,0.1")] public float Linear { get; set; } = 0.5f;
	[Export(PropertyHint.Range, "0,10,0.1")] public float Angular { get; set; } = 1.0f;
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		_spawnPoint = GlobalPosition;
		LinearDamp  = Linear;
		AngularDamp = Angular;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
	
	public override void _PhysicsProcess(double delta)
	{
		if (Fire)
		{
			if (UseImpulse)
			{
				//ApplyCentralImpulse(Vector3.Forward * Strength);
				ApplyImpulse(Vector3.Forward * Strength, new Vector3(0, 0.5f, 0));
				Fire = false; 						  // once
			}
			else
			{
				//ApplyCentralForce(Vector3.Forward * Strength);   // every tick
				ApplyCentralForce(Vector3.Forward * Strength * (float)delta);
			}
		}
		
		Vector3 dir = ReadTemporaryInput();
		if (dir != Vector3.Zero)
		{
			// Roll about the axis PERPENDICULAR to travel: cross(up, direction).
			Vector3 axis = Vector3.Up.Cross(dir).Normalized();
			ApplyTorque(axis * TorqueStrength);
		}
		

		if (GlobalPosition.Y < KillY) Respawn();
	}
	
	// ⚠️ TEMPORARY — hard-coded keys. Chapter 1.16 replaces this with the InputMap.
	// Do not copy this pattern into anything you intend to keep.
	private Vector3 ReadTemporaryInput()
	{
		var d = Vector3.Zero;
		if (Input.IsKeyPressed(Key.W)) d += Vector3.Forward;
		if (Input.IsKeyPressed(Key.S)) d += Vector3.Back;
		if (Input.IsKeyPressed(Key.A)) d += Vector3.Left;
		if (Input.IsKeyPressed(Key.D)) d += Vector3.Right;
		return d.Normalized();
	}
	
	private Vector3 _spawnPoint;
	private int _respawns;
	
	[ExportGroup("Debug")]
	[Export] public bool LogRespawns { get; set; } = true;
	
	private void Respawn()
	{
		_respawns++;
		Fire = false;
		if (LogRespawns) GD.Print($"{Name} respawn #{_respawns}");
		LinearVelocity = Vector3.Zero;
		AngularVelocity = Vector3.Zero;
		GlobalPosition = _spawnPoint;
	}
}

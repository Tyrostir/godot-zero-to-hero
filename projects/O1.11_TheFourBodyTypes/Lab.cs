using Godot;
using System;

public partial class Lab : Node3D
{
	[Export] public bool Push { get; set; } = false;
	[Export] public bool ShoveRigidBodyByHand { get; set; } = false;
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		
	}
	
	private void PushRigidBody(){
		if(!Push) return;
		
		GetNode<RigidBody3D>("RigidBody3D").ApplyImpulse(new Vector3(0, 0, 5f));
		GD.Print("Impulse applied to RigidBody");
		Push = false;
	}
	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		PushRigidBody();
	}
	
	[Export] public float xforce = 0, yforce=0, zforce=0;
	public override void _PhysicsProcess(double delta)
	{
		if (!ShoveRigidBodyByHand) return;

		var b = GetNode<RigidBody3D>("RigidBody3D");
		b.GlobalPosition += new Vector3(xforce * (float)delta, yforce * (float)delta, zforce*(float)delta);   // ❌ the wrong tool
		b.RotateY(Mathf.DegToRad(90f) * (float)delta);              // ❌ so is this
	}
}

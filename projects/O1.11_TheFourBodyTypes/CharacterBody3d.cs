using Godot;
using System;

public partial class CharacterBody3d : CharacterBody3D
{
	[Export] public float Gravity { get; set; } = 20f;
	[Export] public float DriftSpeed { get; set; } = 2f;
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		
		
	}
	
	public override void _PhysicsProcess(double delta){
		
		//Vector3 v = Velocity;
		//
		//if (!IsOnFloor()){
			//GD.Print($"Velocity.Y:\nBefore {v.Y}");
			//v.Y -= Gravity * (float)delta;   // ← YOU write gravity. Nobody does it for you.
			//GD.Print($"After {v.Y}");
		//}
		//else{
			//v.Y = 0f;
		//}
		//v.X = DriftSpeed;
		//Velocity = v;
		//MoveAndSlide();
		
	}
}

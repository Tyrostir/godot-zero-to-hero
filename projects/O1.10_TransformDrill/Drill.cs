using Godot;
using System;

public partial class Drill : Node3D
{
	public enum Task{
		Move, 
		OrbitParent,
		OrbitTrig,
		OrbitBasis,
		AlignLookAt,
		AlignBasis,
		AlignSlerp
	};
	
	[Export] public Task Which {get; set;} = Task.Move;
	[ExportGroup("Orbit")]
	[Export] public float Radius {get;set;} = 4f;
	[Export] public float DegreesPerSecond {get;set;} = 45f;
	
	[ExportGroup("Align")]
	[Export(PropertyHint.Range, "0.5,20,0.5")] public float SlerpRate {get;set;} = 6f;
	
	private Node3D _pivot, _subject, _orbiter, _orbitSubject, _free, _marble;
	private int _pass, _fail;
	private float _angle, _elapsed;
	private bool _sampled;
	
	private void Check(String id, bool ok, string detail=""){
		if(ok) {_pass++; GD.Print($"✅ {id}");}	
		else {_fail++; GD.PrintErr($"❌ {id}  {detail}");}
	}
	
	private void CheckPos(String id, Node3D n, Vector3 expected, float tot = 0.01f) 
	=> Check(id, n.GlobalPosition.DistanceTo(expected) <= tot, $"got {n.GlobalPosition}, want {expected}");
	
	private void CheckFacing(string id, Node3D n, Vector3 target, float degTol = 1f){
		Vector3 want = (target - n.GlobalPosition).Normalized();
		Vector3 forward = -n.GlobalTransform.Basis.Z;
		float deg = Mathf.RadToDeg(forward.AngleTo(want));
		Check(id, deg <= degTol, $"off by {deg:F2}°");
	}
	
	private void Report() => GD.Print($"\n=== {_pass} passed, {_fail} failed ===");
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		_pivot = GetNode<Node3D>("Pivot");
		_subject = GetNode<Node3D>("Pivot/Subject");
		_orbiter = GetNode<Node3D>("Orbiter");
		_orbitSubject = GetNode<Node3D>("Orbiter/OrbitSubject");
		_free = GetNode<Node3D>("FreeSubject");
		_marble = GetNode<Node3D>("Marble");
		
		if(Which == Task.Move) {RunMoveTasks(); Report();}
		else{GD.Print($"not move");}
	}
	
	private void RunMoveTasks(){
		Vector3 target = new Vector3(2,1,-3);
		
		_subject.Position = _pivot.GlobalTransform.AffineInverse() * target;
		GD.Print($"   M1 local position = {_subject.Position}");
		CheckPos("M1", _subject, target);
		
		_subject.Position = Vector3.Zero;
		
		_subject.GlobalPosition = target;
		CheckPos("M2", _subject, target);
		
		_subject.Position = Vector3.Zero;
		_subject.GlobalTransform = new Transform3D(_subject.GlobalTransform.Basis, target);
		CheckPos("M3", _subject, target);
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		switch(Which){
			case Task.OrbitParent: OrbitParent(delta); break;
			case Task.OrbitTrig: OrbitTrig(delta); break;
			case Task.OrbitBasis:  OrbitBasis(delta);  break;
			case Task.AlignLookAt: AlignLookAt();      break;
			case Task.AlignBasis:  AlignBasis();       break;
			case Task.AlignSlerp:  AlignSlerp(delta);  break;
			default: return;
		}
		
		SampleAtTwoSeconds(delta);
	}
	
	private void OrbitParent(double delta)
	=> _orbiter.RotateY(Mathf.DegToRad(DegreesPerSecond) * (float) delta);
	
	private void OrbitTrig(double delta){
		_angle += Mathf.DegToRad(DegreesPerSecond) * (float) delta;
		_free.GlobalPosition = new Vector3(Mathf.Cos(_angle) * Radius, 0f, -Mathf.Sin(_angle) * Radius);
	}
	
	private void OrbitBasis(double delta){
		_angle += Mathf.DegToRad(DegreesPerSecond) * (float)delta;
		Basis b = new Basis(Vector3.Up, _angle);
		_free.GlobalPosition = b * new Vector3(Radius, 0, 0);
	}
	
	private void AlignLookAt() => _free.LookAt(_marble.GlobalPosition, Vector3.Up);
	
	private void AlignBasis(){
		Vector3 forward = (_marble.GlobalPosition - _free.GlobalPosition).Normalized();
		
		if(Mathf.Abs(forward.Dot(Vector3.Up)) > 0.999f) return;
		
		Vector3 right = forward.Cross(Vector3.Up).Normalized();
		Vector3 up = right.Cross(forward);
		
		_free.GlobalBasis = new Basis(right, up, -forward);
	}
	
	private void AlignSlerp(double delta){
		Transform3D want = _free.GlobalTransform.LookingAt(_marble.GlobalPosition, Vector3.Up);
		Quaternion current = _free.GlobalBasis.GetRotationQuaternion();
		Quaternion desired = want.Basis.GetRotationQuaternion();
		float t = 1f - Mathf.Exp(-SlerpRate * (float) delta);
		_free.GlobalBasis = new Basis(current.Slerp(desired, t));
	}
	
	private void SampleAtTwoSeconds(double delta){
		_elapsed += (float) delta;
		if(_sampled || _elapsed < 2f) return;
		_sampled = true;
		
		switch(Which){
			case Task.OrbitParent:
				CheckPos("O1", _orbitSubject, new Vector3(0, 0, -Radius), 0.15f); break;
			case Task.OrbitTrig:
				CheckPos("O2", _free, new Vector3(0,0,-Radius), 0.15f); break;
			case Task.OrbitBasis:
				CheckPos("O3", _free, new Vector3(0, 0, -Radius), 0.15f); break;
			case Task.AlignLookAt:
				CheckFacing("A1", _free, _marble.GlobalPosition); break;
			case Task.AlignBasis:
				CheckFacing("A2", _free, _marble.GlobalPosition); break;
			case Task.AlignSlerp:
				CheckFacing("A3", _free, _marble.GlobalPosition, 2f); break;
		}
		Report();
	}
}

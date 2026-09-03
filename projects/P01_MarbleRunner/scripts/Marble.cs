using Godot;

public partial class Marble : RigidBody3D
{
	[ExportGroup("Respawn")]
	[Export(PropertyHint.Range, "-50,0,1")]
	public float KillY { get; set; } = -10f;

	[Export(PropertyHint.Range, "0,3,0.1")]
	public float RespawnDelay { get; set; } = 0f;

	//[ExportGroup("Feel")]
	//[Export(PropertyHint.Range, "0,1,0.01")]
	//public float Bounciness { get; set; } = 0.3f;
//
	//[Export(PropertyHint.Range, "0,1,0.01")]
	//public float Friction { get; set; } = 0.5f;

	[ExportGroup("Debug")]
	[Export] public bool LogRespawns { get; set; } = true;

	private Vector3 _spawnPoint;
	private int _respawns;
	
	[ExportGroup("Motion")]
	[Export(PropertyHint.Range, "-360,360,5")] public float DegreesPerSecond { get; set; } = 60f;
	[Export] public bool Clockwise { get; set; } = true;

	[Export] public Color Tint { get; set; } = Colors.White;
	public override void _Ready()
	{
		_spawnPoint = GlobalPosition;
		ApplyFeel();
		
		var mesh = GetNode<MeshInstance3D>("MeshInstance3D");
		if(mesh.GetSurfaceOverrideMaterial(0) is StandardMaterial3D shared){
			shared.AlbedoColor = Tint;
			var mine = (StandardMaterial3D) shared.Duplicate();
			mine.AlbedoColor = Tint;
			mesh.SetSurfaceOverrideMaterial(0, mine);
		}
	}

	private void ApplyFeel()
	{
		//var mat = new PhysicsMaterial { Bounce = Bounciness, Friction = Friction };
		//PhysicsMaterialOverride = mat;
	}

	public override void _PhysicsProcess(double delta)
	{
		float dir = Clockwise ? 1f : -1f;
		RotateY(Mathf.DegToRad(DegreesPerSecond) * dir * (float)delta);
		
		if (GlobalPosition.Y < KillY) Respawn();
	}

	private void Respawn()
	{
		_respawns++;
		if (LogRespawns) GD.Print($"{Name} respawn #{_respawns}");
		LinearVelocity = Vector3.Zero;
		AngularVelocity = Vector3.Zero;
		GlobalPosition = _spawnPoint;
	}
}

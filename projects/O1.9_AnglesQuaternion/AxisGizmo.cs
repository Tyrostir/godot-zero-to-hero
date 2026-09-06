using Godot;
using System;

public partial class AxisGizmo : Node3D
{
	[ExportGroup("Spin test")]
	[Export] public bool LerpEuler { get; set; } = false;
	[Export] public float FromDeg { get; set; } = 10f;
	[Export] public float ToDeg   { get; set; } = 350f;
	[Export(PropertyHint.Range, "0.1,3,0.1")] public float Seconds { get; set; } = 2f;

	private float _t;
	[Export] public bool SlerpQuat { get; set; } = false;
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if (SlerpQuat)
		{
			_t = Mathf.Min(_t + (float)delta / Seconds, 1f);

			var from = Quaternion.FromEuler(new Vector3(0, Mathf.DegToRad(FromDeg), 0));
			var to   = Quaternion.FromEuler(new Vector3(0, Mathf.DegToRad(ToDeg),   0));

			Basis = new Basis(from.Slerp(to, _t));
			return;
		}
		
		if (!LerpEuler) return;

		_t = Mathf.Min(_t + (float)delta / Seconds, 1f);
		float y = Mathf.Lerp(FromDeg, ToDeg, _t);          // ❌ naive
		RotationDegrees = new Vector3(0, y, 0);
	}
}

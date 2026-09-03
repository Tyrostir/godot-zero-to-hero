using Godot;

public partial class ProbeB : Node
{
	private int _idleFrames, _physicsTicks;
	private double _elapsed;
	
	public override void _EnterTree()  => GD.Print($"  _EnterTree  {Name}");
	
	public override void _ExitTree()   => GD.Print($"  _ExitTree   {Name}");
	
	public override void _Ready()
	{
		GD.Print($"  _Ready      {Name}");
		GetTree().CreateTimer(3.0).Timeout += () =>
		{
			GD.Print("  --- freeing the marble ---");
			QueueFree();
		};
	}


	public override void _Process(double delta)
	{
		_idleFrames++;
		_elapsed += delta;
		if (_elapsed >= 1.0)
		{
			GD.Print($"  1 second: {_idleFrames} idle frames, {_physicsTicks} physics ticks");
			_idleFrames = _physicsTicks = 0;
			_elapsed = 0;
		}
	}
	
	public override void _PhysicsProcess(double delta) => _physicsTicks++;
	
}

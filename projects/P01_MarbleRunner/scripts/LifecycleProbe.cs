using Godot;
using System;

public partial class LifecycleProbe : Node
{
	// Called when the node enters the scene tree for the first time.

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
	
	public override void _ExitTree()   => GD.Print($"  _ExitTree   {Name}");
	
	public override void _EnterTree()
	{
		GD.Print($"  _EnterTree  {Name}");
		var floor = GetNodeOrNull<Node>("Floor");
		GD.Print($"    in _EnterTree, Floor is: {(floor is null ? "NULL" : floor.Name)}");
	}

	public override void _Ready()
	{
		GD.Print($"  _Ready      {Name}");
		var floor = GetNodeOrNull<Node>("Floor");
		GD.Print($"    in _Ready,     Floor is: {(floor is null ? "NULL" : floor.Name)}");
	}

}

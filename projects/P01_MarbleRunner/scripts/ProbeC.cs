using Godot;

public partial class ProbeC : Node
{
	public override void _EnterTree()  => GD.Print($"  _EnterTree  {Name}");
	public override void _Ready()      => GD.Print($"  _Ready      {Name}");
	public override void _ExitTree()   => GD.Print($"  _ExitTree   {Name}");
}

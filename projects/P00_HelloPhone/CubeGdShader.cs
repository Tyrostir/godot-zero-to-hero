using Godot;
using System;

public partial class CubeGdShader : MeshInstance3D
{
	// Called when the node enters the scene tree for the first time.
	[Export] public Color ShaderTint { get; set; } = new Color(.5f, 1f, 2.5f);
	private MeshInstance3D mesh;
	public override void _Ready()
	{
		var mesh = GetNode<MeshInstance3D>(".");
		if (mesh.MaterialOverride is ShaderMaterial shaderMat)
		{
			shaderMat.SetShaderParameter("tint",
				new Vector3(ShaderTint.R, ShaderTint.G, ShaderTint.B));
			GD.Print($"Shader tint set to {ShaderTint}");
		}else{
			GD.Print($"mesh.MaterialOverride: {mesh.MaterialOverride}");
		}
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}

using Godot;
using System;

public partial class CubeGdShader : MeshInstance3D
{
	// Called when the node enters the scene tree for the first time.
	[Export] public Color ShaderTint { get; set; } = new Color(.5f, 1f, 0.5f);
	private Color prevShaderTint {get;set;} = new Color(); 
	private MeshInstance3D mesh;
	private ShaderMaterial shaderMat;
	public override void _Ready()
	{
		shaderMat = MaterialOverride as ShaderMaterial
		?? GetSurfaceOverrideMaterial(0) as ShaderMaterial
		?? GetActiveMaterial(0) as ShaderMaterial;
		if(shaderMat is null){
			GD.PushError($"{Name}: no shaderMaterial. " + 
			$"MaterialOverride={MaterialOverride}. " + 
			$"SurfaceOverride0={GetSurfaceOverrideMaterial(0)}.");
			return;
		}
		
		shaderMat.SetShaderParameter("tint", new Vector3(ShaderTint.R, ShaderTint.G, ShaderTint.B));
		GD.Print($"Shader tint set to {ShaderTint}");
	}
	

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if(prevShaderTint != ShaderTint){
			shaderMat.SetShaderParameter("tint", new Vector3(ShaderTint.R, ShaderTint.G, ShaderTint.B));
			prevShaderTint = ShaderTint;
		}
	}
}

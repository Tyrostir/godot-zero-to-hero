shader_type spatial;

void vertex() {
	// Called for every vertex the material is visible on.
	VERTEX.y += sin(TIME * 3.0 + VERTEX.x * 2.0) * 0.1;
}

uniform vec3 tint : source_color = vec3(1.0, 0.4, 0.2);
uniform float pulse_speed : hint_range(0.0, 10.0) = 2.0;
uniform float metallic_amount : hint_range(0.0, 1.0) = 0.0;

void fragment() {
	// Called for every pixel the material is visible on.
	float pulse = 0.5 + 0.5 * sin(TIME * pulse_speed);
	ALBEDO = tint * pulse;
	METALLIC = metallic_amount;
	ROUGHNESS = 0.3;
}

//void light() {
//	// Called for every pixel for every light affecting the material.
//	// Uncomment to replace the default light processing function with this one.
//}

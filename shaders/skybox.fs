#version 330 core

out vec4 fragColor;

in vec3 localPos;

uniform samplerCube skybox;

void main() {
    vec3 envColor = textureLod(skybox, localPos, 1.0).rgb;
    envColor = envColor / (envColor + vec3(1.0));
    envColor = pow(envColor, vec3(1.0/2.2));
    fragColor = vec4(envColor, 1.0);
}

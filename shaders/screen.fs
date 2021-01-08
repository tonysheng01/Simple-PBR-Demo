#version 330 core

out vec4 fragColor;

in vec2 texCoords;

uniform sampler2D scene;

void main() {
    fragColor = texture(scene, texCoords);
}

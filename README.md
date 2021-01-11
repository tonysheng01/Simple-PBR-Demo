# Simple-PBR-Demo

This is a simple scene created with the physically-based rendering (PBR) pipeline using OpenGL 3.3, following [Joey de Vries' tutorial][tutorial] on PBR theory.


## About

This demo consists of a matrix of 49 spheres, all with a plain white albedo but varying degrees of roughness and metalness. Roughness increases to the right of the matrix and metalness decreases towards the bottom. Both direct and image-based lighting (IBL) techniques are demonstrated, involving 4 point lights with a warm fluorescent color (indicated by smaller spheres) and indirect illumination calculated by sampling the surrounding environment. Irradiance is modelled with the Cook-Torrance BRDF, using the Trowbridge-Reitz GGX for the NDF, the Schlick-GGX approximation for the geometry function and the Fresnel-Schlick approximation for the Fresnel equation.

> The demo includes a first-person fly style camera which enables free movement within the scene.

![demo1](https://github.com/tonysheng01/Simple-PBR-Scene/blob/main/demo/demo1.png)
![demo2](https://github.com/tonysheng01/Simple-PBR-Scene/blob/main/demo/demo2.png)


## Dependencies

To succcessfully run the demo you will need to download and link to your project the following libraries:
- GLFW
- GLAD (make sure you add glad.c to your project)
- GLM
- stb_image
- FreeType


[tutorial]: https://learnopengl.com/PBR/Theory

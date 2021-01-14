# Simple-PBR-Demo

This is a simple scene created with the physically-based rendering (PBR) pipeline using OpenGL 3.3, following [Joey de Vries' tutorial][tutorial] on PBR theory.


## About

This demo consists of a matrix of 49 spheres, all with a plain white albedo but varying physical properties. Roughness increases to the right of the matrix and metalness decreases towards the bottom. Both direct lighting and image-based lighting (IBL) techniques are demonstrated, involving 4 point lights with a warm fluorescent color (indicated by smaller spheres) and indirect illumination calculated by sampling the surrounding environment. Irradiance is modelled with the Cook-Torrance BRDF, using the Trowbridge-Reitz GGX for the NDF, the Schlick-GGX approximation for the geometry function and the Fresnel-Schlick approximation for the Fresnel equation.

> The demo includes a first-person fly style camera which enables free movement within the scene.

![demo1](https://github.com/tonysheng01/Simple-PBR-Scene/blob/main/demo/demo1.png)
![demo2](https://github.com/tonysheng01/Simple-PBR-Scene/blob/main/demo/demo2.png)


## Dependencies

A functioning OpenGL (3.3 or later) environment is required to run the demo. Make sure you link to your project the following libraries and ensure all include paths are correct.
- GLFW (3.3 or later)
- GLAD (for OpenGL 3.3 or later)
- GLM (0.9.9.8 or later)
- stb_image (2.26 or later)
- FreeType (2.10.4 or later)


[tutorial]: https://learnopengl.com/PBR/Theory

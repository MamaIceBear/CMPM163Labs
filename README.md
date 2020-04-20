# CMPM163Labs
LAB2 PART1: https://drive.google.com/file/d/1WUGlvz_jQ7VJN8aNDgP-VuwTgmHYRWZn/view?usp=sharing

LAB2 PART2:
![](images/Picture.png)

LAB3 FULL: https://drive.google.com/file/d/1yEMPowq-exT7Upv7oBxAS2yofuYAshoV/view?usp=sharing

How I created them:

LEFT (Wireframe): I created a basic mesh material in which I set a cyan color and turned on the wireframe mode.

RIGHT (Two-Color-Interpolation): I interpolated between "aquamarine" and "perano" to make a smooth tealish gradient as shown within the video tutorial.

MIDDLE-BOTTOM (Phong): I created a phong material where its color is gray overall and I made its specular, the color when light shines on the material, green with a 
light-reflection intensity of 30 as shown within the video tutorial.

MIDDLE-TOP (Rainbow): I duplicated fragment shader code and changed it by removing the mix function, which causes interpolation, and the two uniform colors. In gl_FragColor I just placed the whole position of the vUv variable like so... "gl_FragColor = vec4(vUv, 1.0);". I then proceeded to make a new variant of the addCoolCube function to link with the new
fragment shader code.

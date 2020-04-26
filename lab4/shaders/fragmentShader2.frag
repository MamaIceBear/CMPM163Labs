uniform sampler2D texture2;
varying vec2 vUv;

void main() {
	// sample from the texture based on the uv coordinates
	vec2 modifyUV = vUv; //vUv components are const and can't be modified, so just copy it into another vec2
	float tilesize = 2.0;
	float segmentedUV = 1.0/tilesize;
	for(int i = 1; i < 2; i++)
    {
		if(modifyUV.x > segmentedUV)
		{
        	modifyUV.x -= segmentedUV;
		}
		if(modifyUV.y > segmentedUV )
		{
        	modifyUV.y -= segmentedUV;
		}
    }
	gl_FragColor = texture2D(texture2, modifyUV * tilesize);
}
Shader "Tomasz/Color1"{
	Properties {
		_Color ("Color", Color) = (1,0.5,0,1)
	}
	SubShader {
		Pass{
			Color [_Color]
		}
	}
}
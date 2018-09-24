Shader "Tomasz/Texture2"{
	Properties {
		_Color ("Color", Color) = (1,0.5,0,1)
		_MainTex ("Albedo (RGB)", 2D) = "white" {}
	}
	SubShader {
		Pass{
			Color [_Color]
			SetTexture [_MainTex] {
				Combine Primary * Texture
			}
		}
	}
}
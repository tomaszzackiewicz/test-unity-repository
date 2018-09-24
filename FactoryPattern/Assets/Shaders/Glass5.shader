Shader "Tomasz/Glass5"{
	Properties {
		_Color ("Color", Color) = (1,0.5,0,1)
		_MainTex ("Albedo (RGB)", 2D) = "white" {}
	}
	SubShader {
		Tags { "RenderType"="Transparent"}
		//Cull Back
		LOD 100
		Cull Front
		Pass{
			CGPROGRAM
			#pragma surface surf Standard fullforwardshadows alpha vertex:vert
			struct Input {
				float2 uv_MainTex;
			};
			float _Thickness;
			void vert (inout appdata_full v) {
				v.vertex.xyz += v.normal * _Thickness;
			}
			sampler2D _MainTex;
			half _Glossiness;
			half _Metallic;
			fixed4 _Color;
			void surf (Input IN, inout SurfaceOutputStandard o) {
				fixed4 c = tex2D (_MainTex, IN.uv_MainTex) * _Color;
				o.Albedo = c.rgb;
				o.Metallic = _Metallic;
				o.Smoothness = _Glossiness;
				o.Alpha = c.a;
			}
			ENDCG
		}
	}
}
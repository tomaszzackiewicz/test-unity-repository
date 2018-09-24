using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 2/ Concrete class that implements the interface
public class GreyLight : IColorGrey {

	public byte R(){
		byte rColor = 202;
		return rColor;
	}
	public byte G(){
		byte gColor = 204;
		return gColor;
	}
	public byte B(){
		byte bColor = 206;
		return bColor;
	}
	public byte A(){
		byte aColor = 255;
		return aColor;
	}
}

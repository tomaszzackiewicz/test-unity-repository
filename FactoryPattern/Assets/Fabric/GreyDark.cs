using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 2/ Concrete class that implements the interface
public class GreyDark : IColorGrey {
	public byte R(){
		byte rColor = 49;
		return rColor;
	}
	public byte G(){
		byte gColor = 51;
		return gColor;
	}
	public byte B(){
		byte bColor = 53;
		return bColor;
	}
	public byte A(){
		byte aColor = 255;
		return aColor;
	}
}

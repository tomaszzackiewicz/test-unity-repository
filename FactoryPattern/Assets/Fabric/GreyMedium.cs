using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 2/ Concrete class that implements the interface
public class GreyMedium : IColorGrey {
	public byte R(){
		byte rColor = 134;
		return rColor;
	}
	public byte G(){
		byte gColor = 136;
		return gColor;
	}
	public byte B(){
		byte bColor = 138;
		return bColor;
	}
	public byte A(){
		byte aColor = 255;
		return aColor;
	}
}

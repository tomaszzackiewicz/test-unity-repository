using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 4/ Implementation of the methods in the created objects
public class Factory : MonoBehaviour {
	
	public GameObject model;
	
	public void GreyLightButton(){
		int index = 0;
		IColorGrey grey;
		grey = Creation.GetGrey(index);
		byte rColor = grey.R();
		byte gColor = grey.G();
		byte bColor = grey.B();
		byte aColor = grey.A();
		model.GetComponent<Renderer>().material.color = new Color32(rColor,gColor,bColor,aColor);
	}
	
	public void GreyMediumButton(){
		int index = 1;
		IColorGrey grey;
		grey = Creation.GetGrey(index);
		byte rColor = grey.R();
		byte gColor = grey.G();
		byte bColor = grey.B();
		byte aColor = grey.A();
		model.GetComponent<Renderer>().material.color = new Color32(rColor,gColor,bColor,aColor);
	}
	
	public void GreyDarkButton(){
		int index = 2;
		IColorGrey grey;
		grey = Creation.GetGrey(index);
		byte rColor = grey.R();
		byte gColor = grey.G();
		byte bColor = grey.B();
		byte aColor = grey.A();
		model.GetComponent<Renderer>().material.color = new Color32(rColor,gColor,bColor,aColor);
	}
}

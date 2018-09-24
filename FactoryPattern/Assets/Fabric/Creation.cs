using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 3/ Class for creation objects from the concrete classes
public class Creation{

	static public IColorGrey GetGrey(int color){
		IColorGrey Igrey;//Using polimorphism - using a parent class (interface)
		switch(color){//to c
			case 0:
				Igrey = new GreyLight();
				break;
			case 1:
				Igrey = new GreyMedium();
				break;
			case 2:
				Igrey = new GreyDark();
				break;
			default:
				Igrey = new GreyLight();
				break;
		}
		return Igrey;
	}
}

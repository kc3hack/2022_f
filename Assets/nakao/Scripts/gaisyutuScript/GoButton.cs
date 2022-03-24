using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoButton : MonoBehaviour
{
	public string Destination;
	
    public void  OnClick() {
		Debug.Log(Destination);
	}
}

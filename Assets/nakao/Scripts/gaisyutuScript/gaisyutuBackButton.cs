using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gaisyutuBackButton : MonoBehaviour
{
	[SerializeField] private Canvas phoneScreenCanvas;
	
	public void  OnClick() {
		phoneScreenCanvas.gameObject.SetActive(false);
	}
}

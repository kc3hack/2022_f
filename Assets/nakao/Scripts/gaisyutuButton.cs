using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gaisyutuButton : MonoBehaviour
{
	[SerializeField] private Canvas phoneScreenCanvas;
	
	public void  OnClick() {
		phoneScreenCanvas.gameObject.SetActive(true);
		phoneScreenCanvas.GetComponent<gaisyutuCanvas>().Initialize();
	}
	
    // Start is called before the first frame update
    void Start()
    {
		phoneScreenCanvas.gameObject.SetActive(false);
		
    }
}

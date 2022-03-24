using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gaisyutuButton : MonoBehaviour
{
	[SerializeField] private Canvas gaisyutuScreenCanvas;
	
	public void  OnClick() {
		//if()
		gaisyutuScreenCanvas.gameObject.SetActive(true);
		gaisyutuScreenCanvas.GetComponent<gaisyutuCanvas>().Initialize();
	}
	
    // Start is called before the first frame update
    void Start()
    {
		gaisyutuScreenCanvas.gameObject.SetActive(false);
    }
}

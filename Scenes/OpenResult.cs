using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenResult : MonoBehaviour
{
	[SerializeField] private GameObject innsei, yousei, button;
	
    // Start is called before the first frame update
    public void OnClick(){
		button.SetActive(true);
		
		if(InfectionManager.infectionInstance.GetInfection() < 70){
		//if(10 < 70){
			button.GetComponent<GoNext>().next = "innseiEnd";
			innsei.SetActive(true);
		}else{
			button.GetComponent<GoNext>().next = "youseiEnd";
			yousei.SetActive(true);
		}
	}
}

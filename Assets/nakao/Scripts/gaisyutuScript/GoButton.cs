using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoButton : MonoBehaviour
{
	public string Destination;
	[SerializeField] private GameObject GameManager;
	
    public void  OnClick() {
		GoButtonFadeOut.isFadeOut = true;
		//Debug.Log(Destination);
	}
	public void ChangeScene(){
		switch(Destination){
			case "Umi":
			GameManager.GetComponent<GameManagerNakao>().SceneTransition("UmiEvent");
			break;

			case "Natumaturi":
			GameManager.GetComponent<GameManagerNakao>().SceneTransition("NatumaturiEvent");
			break;

			case "BBQ":
			GameManager.GetComponent<GameManagerNakao>().SceneTransition("BBQEvent");
			break;

			case "Camp":
			GameManager.GetComponent<GameManagerNakao>().SceneTransition("CampEvent");
			break;
		}
	}
}

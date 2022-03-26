using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoButton : MonoBehaviour
{
	public string Destination;
	[SerializeField] private GameObject GameManager;
	[SerializeField] private JkEvent umi, natumaturi, camp, bbq;
	
    public void  OnClick() {
		//Debug.Log(Destination);
		GoButtonFadeOut.isFadeOut = true;
	}
	
	public void Start(){
	}
	
	public void ChangeScene(){
		switch(Destination){
			case "Umi":
			GameManager.GetComponent<GameManagerNakao>().changeStates(umi);
			GameManager.GetComponent<GameManagerNakao>().SceneTransition("UmiEvent");
			break;

			case "Natumaturi":
			GameManager.GetComponent<GameManagerNakao>().changeStates(natumaturi);
			GameManager.GetComponent<GameManagerNakao>().SceneTransition("NatumaturiEvent");
			break;

			case "BBQ":
			GameManager.GetComponent<GameManagerNakao>().changeStates(bbq);
			GameManager.GetComponent<GameManagerNakao>().SceneTransition("BBQEvent");
			break;

			case "Camp":
			GameManager.GetComponent<GameManagerNakao>().changeStates(camp);
			GameManager.GetComponent<GameManagerNakao>().SceneTransition("CampEvent");
			break;
		}
	}
}

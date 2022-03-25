using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoButton : MonoBehaviour
{
	public string Destination;
	[SerializeField] private GameObject GameManager;
	
    public void  OnClick() {
		//Debug.Log(Destination);
		GameManager.GetComponent<GameManagerNakao>().SceneTransition("TestScene");
	}
}

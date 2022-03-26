using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneChange : MonoBehaviour
{
	[SerializeField] private GameObject GameManager;
	private GameManagerNakao GMScript; 
	
    public void OnClick(){
		GMScript = GameManager.GetComponent<GameManagerNakao>();
		GMScript.SceneTransition("TestScene");
	}
}

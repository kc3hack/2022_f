using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoNext : MonoBehaviour
{
    public string next;
	
	public void OnClick(){
		BGMManager.BGMInstance.ChangeVolume();
		if(next == "innseiEnd"){
			BGMManager.BGMInstance.PlayBGM(3);
		}
		else{
			BGMManager.BGMInstance.PlayBGM(4);
		}
		SceneManager.LoadScene(next);
	}
}

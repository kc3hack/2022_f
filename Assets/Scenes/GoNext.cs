using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoNext : MonoBehaviour
{
    public string next;
	
	public void OnClick(){
		SceneManager.LoadScene(next);
	}
}

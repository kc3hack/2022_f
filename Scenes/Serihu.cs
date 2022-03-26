using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Serihu : MonoBehaviour
{
	[SerializeField] private Text T;
	[SerializeField] private string next;
	private AudioSource audioSource;
	[SerializeField] private List<string> serihu;
	public int i = 0, j = 0;
	private const float START_SECONDS = 0.0f;
	/// <summary>  更新間隔時間(秒)　</summary>
	private const float INTERVA_SECONDS = 0.15f;
	

    // Update is called once per frame
    void Start()
    {
		audioSource = this.GetComponent<AudioSource>();
        InvokeRepeating("TextProcess", START_SECONDS, INTERVA_SECONDS);
    }
	
	private void TextProcess(){
		//Debug.Log(serihu[i]);
		if(serihu[i].Length > j){
			if(serihu[i][j] == 'n')T.text = T.text + "\n";
			else T.text = T.text + serihu[i][j];
			//T.text = T.text + "a";
			audioSource.Play();
			j++;
		}
	}
	
	public void inc(){
		if(i == serihu.Count)SceneManager.LoadScene("PhoneCommandScene");;
		i++; j=0;
		T.text = "";
		if(serihu.Count == i)
			SceneManager.LoadScene(next);
	}
}

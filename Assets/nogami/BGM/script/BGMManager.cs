using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMManager : MonoBehaviour
{
    public static BGMManager BGMInstance {get; private set;}
    private AudioSource audioSource;
    private void Awake(){
        if(BGMInstance == null){
            BGMInstance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else{
            Destroy(this.gameObject);
        }
        audioSource = this.gameObject.GetComponent<AudioSource>();
    }
    public void StopBGM(){
        audioSource.Stop();
    }
    public void PlayBGM(){
        audioSource.Play();
    }
}

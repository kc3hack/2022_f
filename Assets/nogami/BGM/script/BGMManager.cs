using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMManager : MonoBehaviour
{
    public static BGMManager BGMInstance {get; private set;}
    private AudioSource audioSource;
    [SerializeField] private List<AudioClip> audioClips = new List<AudioClip>();
    private bool isChangeVolume = false;
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
    public void PlayBGM(int BGMnum){
        audioSource.clip = audioClips[BGMnum];
        audioSource.Play();
    }
    public void ChangeVolume(){
        if(isChangeVolume == true){
            audioSource.volume = 0.01f;
        }
        else{
            audioSource.volume = 0.005f;
        }
        isChangeVolume = !isChangeVolume;
    }
}

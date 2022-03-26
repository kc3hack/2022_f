using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SleepFadeOut : MonoBehaviour
{
    public static bool isFadeOut = true;
    private float fadeSpeed = 0.0013f;
    private float red, green, blue, alfa;

    [SerializeField] Image fadeImage;

    private void Awake(){
        red = fadeImage.color.r;
        green = fadeImage.color.g;
        blue = fadeImage.color.b;
        alfa = fadeImage.color.a;
    }

    private void Update(){
        if(isFadeOut){
            StartFadeOut();
        }
    }

    private void StartFadeOut(){
        fadeImage.enabled = true;
        alfa += fadeSpeed;
        this.SetAlpha();
        if(alfa >= 1){
            isFadeOut = false;
            SceneManager.LoadScene("PhoneCommandScene");
        }
    }
    private void SetAlpha(){
        fadeImage.color = new Color(red, green, blue, alfa);
    }
    private void ResetAlpha(){
        fadeImage.color = new Color(red, green, blue, 0);
    }
}

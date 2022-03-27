using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SleepFadeOut : MonoBehaviour
{
    public static bool isFadeOut = false;
    private float fadeSpeed = 0.013f;
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
        alfa += fadeSpeed;
        this.SetAlpha();
        if(alfa >= 1){
            isFadeOut = false;
            SceneManager.LoadScene("Compile");
        }
    }
    private void SetAlpha(){
        fadeImage.color = new Color(red, green, blue, alfa);
    }
    private void ResetAlpha(){
        fadeImage.color = new Color(red, green, blue, 0);
    }
}

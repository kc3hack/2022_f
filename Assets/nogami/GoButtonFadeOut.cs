using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoButtonFadeOut : MonoBehaviour
{
    public static bool isFadeOut = false;
    private float fadeSpeed = 0.01f;
    private float red, green, blue, alfa;
    [SerializeField] Image fadeImage;
    [SerializeField] GoButton goButton;

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
        fadeImage.gameObject.SetActive(true);
        alfa += fadeSpeed;
        this.SetAlpha();
        if(alfa >= 1){
            isFadeOut = false;
            fadeImage.gameObject.SetActive(false);
            goButton.ChangeScene();
        }
    }
    private void SetAlpha(){
        fadeImage.color = new Color(red, green, blue, alfa);
    }
    private void ResetAlpha(){
        fadeImage.color = new Color(red, green, blue, 0);
    }
}

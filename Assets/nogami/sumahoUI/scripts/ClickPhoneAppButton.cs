using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickPhoneAppButton : MonoBehaviour
{
    [SerializeField] private Canvas appCanvas;
    [SerializeField] private Canvas thisCanvas;
    public void OnClick(){
        appCanvas.gameObject.SetActive(true);
        thisCanvas.gameObject.SetActive(false);
    }
}

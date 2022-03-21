using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickPhoneButton : MonoBehaviour
{
    [SerializeField] private Canvas phoneScreenCanvas;
    public void OnClick(){
        phoneScreenCanvas.gameObject.SetActive(true);
    }
}

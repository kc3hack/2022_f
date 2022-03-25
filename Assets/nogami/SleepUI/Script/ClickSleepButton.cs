using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickSleepButton : MonoBehaviour
{
    [SerializeField] private Canvas sleepConfirmation;
    public void OnClick(){
        this.sleepConfirmation.gameObject.SetActive(true);
    }
}

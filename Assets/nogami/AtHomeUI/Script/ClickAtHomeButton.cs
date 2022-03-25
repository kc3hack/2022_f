using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickAtHomeButton : MonoBehaviour
{
    [SerializeField] private Canvas atHomeConfirmation;

    public void OnClick(){
        atHomeConfirmation.gameObject.SetActive(true);
    }
}

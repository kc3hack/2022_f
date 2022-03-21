using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickBack : MonoBehaviour
{
    [SerializeField] private Canvas thisCanvas;
    public void OnClick(){
        this.thisCanvas.gameObject.SetActive(false);
    }
}

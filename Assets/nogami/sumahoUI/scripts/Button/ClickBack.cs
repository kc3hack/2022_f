using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickBack : MonoBehaviour
{
    [SerializeField] private Canvas thisCanvas;
    [SerializeField] private Canvas prevCanvas;
    public void OnClick(){
        this.thisCanvas.gameObject.SetActive(false);
        this.prevCanvas.gameObject.SetActive(true);
    }
}

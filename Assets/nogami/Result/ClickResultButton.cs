using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickResultButton : MonoBehaviour
{
    [SerializeField] OPEDFadeOut opedFadeOut;
    public void OnClick(){
        opedFadeOut.ChangeIsFadeOut();
    }
}

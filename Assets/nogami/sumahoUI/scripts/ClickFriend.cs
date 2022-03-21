using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickFriend : MonoBehaviour
{
    [SerializeField] private Canvas MessageScreen;
    private int friendNum;
    public void OnClick(){
        MessageScreen.gameObject.SetActive(true);
    }
}

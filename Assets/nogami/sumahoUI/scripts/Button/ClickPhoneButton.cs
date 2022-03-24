using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickPhoneButton : MonoBehaviour
{
    [SerializeField] private Canvas phoneScreenCanvas;
    [SerializeField] private FriendMessageController fMessageController;
    public void OnClick(){
        fMessageController.SetupFriendValue();
        this.phoneScreenCanvas.gameObject.SetActive(true);
    }
}

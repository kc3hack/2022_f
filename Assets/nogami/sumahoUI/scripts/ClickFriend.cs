using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickFriend : MonoBehaviour
{
    [SerializeField] private Canvas MessageScreen;
    [SerializeField] private Canvas thisCanvas;
    [SerializeField] private FriendMessageController fMessageController;
    private FriendMessage friendMessage;
    [SerializeField] private int messageNum;
    private void Awake(){
        friendMessage = MessageScreen.GetComponent<FriendMessage>();
    }

    public void OnClick(){
        MessageScreen.gameObject.SetActive(true);
        this.friendMessage.initialize();
        thisCanvas.gameObject.SetActive(false);
    }
}

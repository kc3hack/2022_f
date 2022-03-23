using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FriendMessageController : MonoBehaviour
{
    [SerializeField] private List<Button> messageList = new List<Button>();
    private FriendStatusValue[] friendValue = new FriendStatusValue[3];
    private int todayFriendCount = 0;
    private void Awake(){
        this.FriendInitialize();
    }
    public void FriendInitialize(){
        foreach(Button button in messageList){
            button.gameObject.SetActive(false);
        }
        todayFriendCount = 0;
    }
    public void SetFriendValue(string name, string message){
        friendValue[todayFriendCount].SetName(name);
        friendValue[todayFriendCount].SetMessage(message);
        messageList[todayFriendCount].gameObject.SetActive(true);
        todayFriendCount++;
    }
    public FriendStatusValue GetFriendValue(int messageNum){
        return friendValue[messageNum];
    }
}

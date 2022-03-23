using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FriendMessageController : MonoBehaviour
{
    [SerializeField] private List<Button> messageList = new List<Button>();
    private FriendStatusValue[] friendValue = new FriendStatusValue[3];
    private int todayFriendCount = 0;
    public void SetFriendValue(string name, string message){
        friendValue[todayFriendCount].SetName(name);
        friendValue[todayFriendCount].SetMessage(message);
        todayFriendCount++;
    }
}

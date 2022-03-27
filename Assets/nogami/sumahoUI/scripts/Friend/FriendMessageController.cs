using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FriendMessageController : MonoBehaviour
{
    [SerializeField] private List<Button> messageList = new List<Button>();
    private List<FriendStatusValue> friendValue = new List<FriendStatusValue>();
    [SerializeField] private List<Text> fName = new List<Text>();
    [SerializeField] private List<Text> fMessage = new List<Text>();
    [SerializeField] private Calendar calendar;
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
    public void SetupFriendValue(){
        friendValue.Clear();
        friendValue.AddRange(calendar.getSumahoEvent());
        todayFriendCount = friendValue.Count;
        for(int i = 0;i < todayFriendCount;i++){
            messageList[i].gameObject.SetActive(true);
            fName[i].text = friendValue[i].GetName();
            fMessage[i].text = friendValue[i].GetMessage();
        }
    }
    public FriendStatusValue GetFriendValue(int messageNum){
        return friendValue[messageNum];
    }
}

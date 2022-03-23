using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FriendMessage : MonoBehaviour
{
    [SerializeField] private Text friendName;
    [SerializeField] private Text message;
    public void initialize(FriendStatusValue friendStatus){
        friendName.text = friendStatus.GetName();
        message.text = friendStatus.GetMessage();
    }
}

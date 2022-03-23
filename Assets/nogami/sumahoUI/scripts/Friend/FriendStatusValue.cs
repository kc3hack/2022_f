using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriendStatusValue : MonoBehaviour
{
    private string friendName;
    private string friendMessage;
    public string GetName(){
        return friendName;
    }
    public string GetMessage(){
        return friendMessage;
    }
    public void SetName(string name){
        friendName = name;
    }
    public void SetMessage(string message){
        friendMessage = message;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotDestroy : MonoBehaviour
{
    public static NotDestroy notDestroyInstance {get; private set;}
    private void Awake(){
        if(notDestroyInstance == null){
            notDestroyInstance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else{
            Destroy(this.gameObject);
        }
    }
}

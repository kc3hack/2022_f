using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfectionManager : MonoBehaviour
{
    public static InfectionManager infectionInstance {get; private set;}
    private int infectionValue;
    private bool lastDay;
    private void Awake(){
        if(infectionInstance == null){
            infectionInstance = this;
            DontDestroyOnLoad(this);
        }
        else{
            Destroy(this);
        }
    }
    public void SetInfection(int value){
        infectionValue = value;
    }
    public int GetInfection(){
        return infectionValue;
    }
    public void ChangeLastDay(){
        lastDay = !lastDay;
    }
}

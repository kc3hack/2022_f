using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfectionManager : MonoBehaviour
{
    public static InfectionManager infectionInstance {get; private set;}
    private int infectionValue;
    private List<int> infectionValueList;
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
    public void SetInfectionList(List<int> value){
        infectionValueList = value;
        Debug.Log(infectionValueList.Count);
		infectionValue = infectionValueList[30];
    }
    public List<int> GetInfectionList(){
        return infectionValueList;
    }
}

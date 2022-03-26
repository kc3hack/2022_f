using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JudgeEndRoot : MonoBehaviour
{
    private void Awake(){
        Debug.Log(InfectionManager.infectionInstance.GetInfection());
    }
}

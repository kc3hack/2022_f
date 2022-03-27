using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtHome : JkEvent
{
    private void Awake(){
        this.Initialize();
    }
    private void Initialize(){
        healthValue = -7;
        infectionValue = -6;
        stressValue = 6;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sleep : JkEvent
{
    private void Awake(){
        this.Initialize();
    }
    private void Initialize(){
        healthValue = -4;
        infectionValue = -7;
        stressValue = 8;
    }
}

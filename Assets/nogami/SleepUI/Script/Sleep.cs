using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sleep : JkEvent
{
    private void Awake(){
        this.Initialize();
    }
    private void Initialize(){
        healthValue = 0;
        infectionValue = 0;
        stressValue = 0;
    }
}

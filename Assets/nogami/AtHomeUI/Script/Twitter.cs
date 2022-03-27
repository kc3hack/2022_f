using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Twitter : JkEvent
{
    private void Awake(){
        this.Initialize();
    }
    private void Initialize(){
        healthValue = -6;
        infectionValue = -6;
        stressValue = 7;
    }
}

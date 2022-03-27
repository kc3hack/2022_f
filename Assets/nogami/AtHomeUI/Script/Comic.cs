using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comic : JkEvent
{
    private void Awake(){
        this.Initialize();
    }
    private void Initialize(){
        healthValue = -8;
        infectionValue = -7;
        stressValue = 5;
    }
}

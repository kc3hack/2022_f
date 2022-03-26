using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : JkEvent
{
    private void Awake(){
        this.Initialize();
    }
    private void Initialize(){
        healthValue = -5;
        infectionValue = -6;
        stressValue = 9;
    }
}

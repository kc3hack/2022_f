using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeSleepScene : MonoBehaviour
{
    [SerializeField] private GameManagerNakao gameManager;
    [SerializeField] private JkEvent sleepValue;

    public void OnClick(){
        gameManager.changeStates(sleepValue);
        SleepFadeOut.isFadeOut = true;
        gameManager.SceneTransition("SleepScene");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeAtHomeScene : MonoBehaviour
{
    [SerializeField] private GameManagerNakao gameManager;
    [SerializeField] private JkEvent atHomeEvent;

    public void OnClick(){
        gameManager.changeStates(atHomeEvent);
        gameManager.SceneTransition("AtHomeScene");
    }
}

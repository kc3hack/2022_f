using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeAtHomeScene : MonoBehaviour
{
    [SerializeField] private GameManagerNakao gameManager;

    public void OnClick(){
        gameManager.SceneTransition("AtHomeScene");
    }
}

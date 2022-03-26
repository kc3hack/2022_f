using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AtHomeToMain : MonoBehaviour
{
    [SerializeField] private JkEvent eventStatus;
    public void OnClick(){
        //GameManagerをDontDestroyonLordにしてeventStatusの値を渡す
        SceneManager.LoadScene("PhoneCommandScene");
    }
}

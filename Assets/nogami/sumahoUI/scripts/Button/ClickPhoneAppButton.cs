using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickPhoneAppButton : MonoBehaviour
{
    [SerializeField] private Canvas appCanvas;
    [SerializeField] private Canvas thisCanvas;
    [SerializeField] private Calendar calenderManager;
    [SerializeField] private GameObject jkIcon;
    [SerializeField] private GameObject calender;
    [SerializeField] private CalenderUI calenderUI;
    [SerializeField] private bool isCalendar;
    public void OnClick(){
        appCanvas.gameObject.SetActive(true);
        thisCanvas.gameObject.SetActive(false);
        if(isCalendar == true){
            calenderUI.MoveIcon(calenderManager.getDay());
            calenderUI.setEventIconButton(calenderManager.getClandarEvent());
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CalenderButton : MonoBehaviour
{
    [SerializeField] private Canvas calenderCanvas;

    [SerializeField] private Calendar calenderManager;

    [SerializeField] private GameObject jkIcon;

    [SerializeField] private GameObject calender;

    [SerializeField] private CalenderUI calenderUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        Debug.Log("sumaho");
        calenderCanvas.gameObject.SetActive(true);
        calenderUI.MoveIcon(calenderManager.getDay());
        calenderUI.setEventIconButton(calenderManager.getClandarEvent());
    }
}

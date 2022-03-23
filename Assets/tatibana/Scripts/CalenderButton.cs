using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CalenderButton : MonoBehaviour
{
    [SerializeField] private Canvas calenderCanvas;

    [SerializeField] private GameManager gameManager;

    [SerializeField] private GameObject jkIcon;

    [SerializeField] private GameObject calender;
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
        MoveIcon(gameManager.getDay());
    }

    public void MoveIcon(int day)
    {
        if (day >= 28)
        {
            jkIcon.transform.position = new Vector3(jkIcon.transform.position.x, calender.transform.position.y - 389, 0);
        }
        else if (day >= 21)
        {
            jkIcon.transform.position = new Vector3(jkIcon.transform.position.x, calender.transform.position.y - 273, 0);
        }
        else if (day >= 14)
        {
            jkIcon.transform.position = new Vector3(jkIcon.transform.position.x, calender.transform.position.y - 150 , 0);
        }
        else if (day >= 7)
        {
            jkIcon.transform.position = new Vector3(jkIcon.transform.position.x, calender.transform.position.y - 28, 0);
        }
        else
        {
            jkIcon.transform.position = new Vector3(jkIcon.transform.position.x, calender.transform.position.y + 90, 0);
        }

        switch (day % 7)
        {
            case 0:
                jkIcon.transform.position = new Vector3(calender.transform.position.x - 250, jkIcon.transform.position.y, 0);
                break;
            case 1:
                jkIcon.transform.position = new Vector3(calender.transform.position.x - 166, jkIcon.transform.position.y, 0);
                break;
            case 2:
                jkIcon.transform.position = new Vector3(calender.transform.position.x - 78, jkIcon.transform.position.y, 0);
                break;
            case 3:
                jkIcon.transform.position = new Vector3(calender.transform.position.x + 7, jkIcon.transform.position.y, 0);
                break;
            case 4:
                jkIcon.transform.position = new Vector3(calender.transform.position.x + 89, jkIcon.transform.position.y, 0);
                break;
            case 5:
                jkIcon.transform.position = new Vector3(calender.transform.position.x + 172, jkIcon.transform.position.y, 0);
                break;
            case 6:
                jkIcon.transform.position = new Vector3(calender.transform.position.x + 260, jkIcon.transform.position.y, 0);
                break;
            default:
                jkIcon.transform.position = new Vector3(jkIcon.transform.position.x, jkIcon.transform.position.y, 0);
                break;
        }
    }
}

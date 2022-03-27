using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CalenderUI : MonoBehaviour
{
    [SerializeField] private Canvas calenderCanvas;

    [SerializeField] private Calendar calenderManager;

    [SerializeField] private GameObject jkIcon;

    [SerializeField] private GameObject calender;

    [SerializeField] private List<EventIconButton> eventIconButtons;

    [SerializeField] private Sprite BBQSprite;

    [SerializeField] private Sprite NatsumatsuriSprite;

    [SerializeField] private Sprite CampSprite;

    [SerializeField] private Sprite UmiSprite;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
            jkIcon.transform.position = new Vector3(jkIcon.transform.position.x, calender.transform.position.y - 150, 0);
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

    public void setEventIconButton(List<int> CalendarEventList)
    {
        for (int i = 0; CalendarEventList.Count > i; i++)
        {
            switch (CalendarEventList[i])
            {
                case 1:
                    eventIconButtons[i].setSprite(BBQSprite);
                    eventIconButtons[i].GetComponent<Image>().color = new Color(255, 255, 255, 255);
                    break;
                case 2:
                    eventIconButtons[i].setSprite(NatsumatsuriSprite);
                    eventIconButtons[i].GetComponent<Image>().color = new Color(255, 255, 255, 255);
                    break;
                case 3:
                    eventIconButtons[i].setSprite(CampSprite);
                    eventIconButtons[i].GetComponent<Image>().color = new Color(255, 255, 255, 255);
                    break;
                case 4:
                    eventIconButtons[i].setSprite(UmiSprite);
                    eventIconButtons[i].GetComponent<Image>().color = new Color(255, 255, 255, 255);
                    break;
                default:
                    eventIconButtons[i].setSprite(null);
                    eventIconButtons[i].GetComponent<Image>().color = new Color(255, 255, 255, 0);
                    break;
            }
        }

        for (int i = 0; CalendarEventList.Count > i; i++)
        {
            switch (CalendarEventList[i])
            {
                case 1:
                    eventIconButtons[i].setText("BBQ");
                    break;
                case 2:
                    eventIconButtons[i].setText("âƒç’ÇË");
                    break;
                case 3:
                    eventIconButtons[i].setText("ÉLÉÉÉìÉv");
                    break;
                case 4:
                    eventIconButtons[i].setText("äC");
                    break;
                default:
                    eventIconButtons[i].setText("");
                    break;
            }
        }
    }
}

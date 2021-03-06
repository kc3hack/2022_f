using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager2 : MonoBehaviour
{
    //日にち
    [SerializeField] private int day;

    //イベント情報
    [SerializeField] private List<JkEvent> eventList = new List<JkEvent>();

    //主人公のパラメータ
    [SerializeField] private JkModel jk;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    //日にちのゲッター
    public int getDay()
    {
        return day;
    }

    //イベント情報のゲッター
    public List<JkEvent> getEventList()
    {
        return eventList;
    }

    //イベント情報のゲッター
    public JkEvent getEvent(int eventNumber)
    {
        return eventList[eventNumber];
    }

    //ステータスを変化させる
    public void changeStates(int healthValue, int infectionValue, int stressValue)
    {

    }

    public void ChangeDate()
    {
        day += 1;
    }
}

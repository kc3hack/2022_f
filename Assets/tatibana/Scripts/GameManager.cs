using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class GameManager
{
    //日にち
    [SerializeField] private static int day;

    //イベント情報
    [SerializeField] private static List<JkEvent> eventList = new List<JkEvent>();

    //主人公のパラメータ
    [SerializeField] private static JkModel jk;

    //日にちのゲッター
    public static int getDay()
    {
        return day;
    }

    //イベント情報のゲッター
    public static List<JkEvent> getEventList()
    {
        return eventList;
    }

    //イベント情報のゲッター
    public static JkEvent getEvent(int eventNumber)
    {
        return eventList[eventNumber];
    }

    //ステータスを変化させる
    public static void changeStates(int healthValue, int infectionValue, int stressValue)
    {

    }

    public static void ChangeDate()
    {
        day += 1;
    }

    public static void EventStart()
    {
        ChangeDate();
        SceneManager.LoadScene("Natsumatsuri");
    }
}

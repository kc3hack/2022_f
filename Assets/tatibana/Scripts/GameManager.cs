using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class GameManager
{
    //���ɂ�
    [SerializeField] private static int day;

    //�C�x���g���
    [SerializeField] private static List<JkEvent> eventList = new List<JkEvent>();

    //��l���̃p�����[�^
    [SerializeField] private static JkModel jk;

    //���ɂ��̃Q�b�^�[
    public static int getDay()
    {
        return day;
    }

    //�C�x���g���̃Q�b�^�[
    public static List<JkEvent> getEventList()
    {
        return eventList;
    }

    //�C�x���g���̃Q�b�^�[
    public static JkEvent getEvent(int eventNumber)
    {
        return eventList[eventNumber];
    }

    //�X�e�[�^�X��ω�������
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

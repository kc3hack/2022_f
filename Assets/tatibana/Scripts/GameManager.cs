using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //���ɂ�
    private int day;

    //�C�x���g���
    private List<JkEvent> eventList = new List<JkEvent>();

    //��l���̃p�����[�^
    private JkModel jk;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //���ɂ��̃Q�b�^�[
    public int getDay()
    {
        return day;
    }

    //�C�x���g���̃Q�b�^�[
    public List<JkEvent> getEventList()
    {
        return eventList;
    }

    //�C�x���g���̃Q�b�^�[
    public JkEvent getEvent(int eventNumber)
    {
        return eventList[eventNumber];
    }

    //�X�e�[�^�X��ω�������
    public void changeStates(int healthValue, int infectionValue, int stressValue)
    {

    }
}

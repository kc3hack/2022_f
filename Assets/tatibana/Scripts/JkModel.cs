using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JkModel : MonoBehaviour
{

    //���N�x
    private int healthValue;

    //�����x
    private int infectionValue;

    //�X�g���X�x
    private int stressValue;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //healthValue�̃Q�b�^�[
    public int getHealthValue()
    {
        return healthValue;
    }

    //infectionValue�̃Q�b�^�[
    public int getInfectionValue()
    {
        return infectionValue;
    }

    //stressValue�̃Q�b�^�[
    public int getStressValue()
    {
        return stressValue;
    }

    //�X�e�[�^�X��ω�������
    public void changeStates(int healthValue, int infectionValue, int stressValue)
    {

    }
}

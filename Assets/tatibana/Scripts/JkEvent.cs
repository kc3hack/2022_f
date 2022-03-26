using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class JkEvent : MonoBehaviour
{
    //�V�[���̖��O
    [SerializeField] protected string sceneName;

    //���N�x
    [SerializeField] protected int healthValue;

    //�����x
    [SerializeField] protected int infectionValue;

    //�X�g���X�x
    [SerializeField] protected int stressValue;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //sceneName�̃Q�b�^�[
    public string getSceneName()
    {
        return sceneName;
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
}

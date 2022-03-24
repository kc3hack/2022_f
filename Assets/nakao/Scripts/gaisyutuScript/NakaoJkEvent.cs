using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class NakaoJkEvent
{
    //シーンの名前
    [SerializeField] protected string sceneName;

    //健康度
    [SerializeField] protected int healthValue;

    //感染度
    [SerializeField] protected int infectionValue;

    //ストレス度
    [SerializeField] protected int stressValue;

    //sceneNameのゲッター
    public string getSceneName()
    {
        return sceneName;
    }

    //healthValueのゲッター
    public int getHealthValue()
    {
        return healthValue;
    }

    //infectionValueのゲッター
    public int getInfectionValue()
    {
        return infectionValue;
    }

    //stressValueのゲッター
    public int getStressValue()
    {
        return stressValue;
    }
}

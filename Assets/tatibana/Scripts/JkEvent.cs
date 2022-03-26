using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class JkEvent : MonoBehaviour
{
    //シーンの名前
    [SerializeField] protected string sceneName;

    //健康度
    [SerializeField] protected int healthValue;

    //感染度
    [SerializeField] protected int infectionValue;

    //ストレス度
    [SerializeField] protected int stressValue;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

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

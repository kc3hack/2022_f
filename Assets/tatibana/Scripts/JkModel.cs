using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JkModel : MonoBehaviour
{

    //健康度
    private int healthValue;

    //感染度
    private int infectionValue;

    //ストレス度
    private int stressValue;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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

    //ステータスを変化させる
    public void changeStates(int healthValue, int infectionValue, int stressValue)
    {

    }
}

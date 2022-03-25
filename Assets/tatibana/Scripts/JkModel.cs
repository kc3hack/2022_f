using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JkModel : MonoBehaviour
{

    //健康度 減少すると危険
    [SerializeField] private static int healthValue = 0;

    //感染度 たまると危険
    [SerializeField] private static int infectionValue = 0;

    //ストレス度 たまると危険
    [SerializeField] private static int stressValue = 0;

    [SerializeField] private List<Sprite> gages;

    [SerializeField] private List<Sprite> jks;

    [SerializeField] private Image gage;

    [SerializeField] private Image jk;

    // Start is called before the first frame update
    void Start()
    {
        changeSprite();
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
    public void changeStates(int health, int infection, int stress)
    {
        healthValue += health;

        if(healthValue <= 0)
        {
            healthValue = 0;
        }else if (healthValue >= 100)
        {
            healthValue = 100;
        }

        infectionValue += infection;

        if (infectionValue <= 0)
        {
            infectionValue = 0;
        }
        else if (infectionValue >= 100)
        {
            infectionValue = 100;
        }

        stressValue += stress;

        if (stressValue <= 0)
        {
            stressValue = 0;
        }
        else if (stressValue >= 70)
        {
            stressValue = 100;
        }
    }

    public void changeSprite()
    {
        if (stressValue == 0)
        {
            gage.sprite = gages[7];
        }
        else if (stressValue <= 9)
        {
            gage.sprite = gages[6];
        }
        else if (stressValue <= 19)
        {
            gage.sprite = gages[5];
        }
        else if (stressValue <= 29)
        {
            gage.sprite = gages[4];
        }
        else if (stressValue <= 39)
        {
            gage.sprite = gages[3];
        }
        else if (stressValue <= 49)
        {
            gage.sprite = gages[2];
        }
        else if (stressValue <= 69)
        {
            gage.sprite = gages[1];
        }
        else if (stressValue == 70)
        {
            gage.sprite = gages[0];
        }

        if (healthValue <= 25)
        {
            jk.sprite = jks[2];
        }
        else if (healthValue <= 70)
        {
            jk.sprite = jks[1];
        }
        else if (healthValue <= 100)
        {
            jk.sprite = jks[0];
        }
    }
}

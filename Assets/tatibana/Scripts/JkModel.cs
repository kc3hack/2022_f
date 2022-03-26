using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class JkModel : MonoBehaviour
{

    //���N�x ��������Ɗ댯
    [SerializeField] private static int healthValue = 0;

    //�����x ���܂�Ɗ댯
    [SerializeField] private static int infectionValue = 0;

    //�X�g���X�x ���܂�Ɗ댯
    [SerializeField] private static int stressValue = 0;

    [SerializeField] private List<Sprite> gages;

    [SerializeField] private List<Sprite> jks;

    [SerializeField] private Image gage;

    [SerializeField] private Image jk;
    [SerializeField] private Calendar calendar;

    [SerializeField] private static List<int> infectionData = new List<int>();
    /*[SerializeField] private static List<int> infectionData = new List<int>(){
        2,
        2,
        1,
        4,
        5,
        60,
        70,
        100,
        80,
        90,
        70,
        60,
        50,
        48,
        43,
        42,
        39,
        28,
        19,
        20,
        21,
        22,
        23,
        24,
        25,
        26,
        27,
        28,
        29,
        30,
        31,
    };*/

    // Start is called before the first frame update
    void Start()
    {
        changeSprite();
        
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
    public static void JKInititalize(){
        healthValue = 0;
        infectionValue = 0;
        stressValue = 0;
        infectionData = new List<int>();
    }

    public static List<int> getInfectionData()
    {
        return infectionData;
    }

    //�X�e�[�^�X��ω�������
    public void changeStates(int health, int infection, int stress)
    {
        infectionData.Add(infectionValue);

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

        if (stressValue >= 70)
        {
            BGMManager.BGMInstance.StopBGM();
            calendar.Inititalize();
            SceneManager.LoadScene("Utu");
        }

    }
}

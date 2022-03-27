using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
 
 
public class GameManagerNakao : MonoBehaviour
{
    //日にち
    [SerializeField] static private  int day = 1;

    //主人公のパラメータ
    [SerializeField] private JkModel jk;
    // Start is called before the first frame update
    void Start()
    {
    }
	
	public void SceneTransition(string nextScene){
		day++;
		SceneManager.LoadScene(nextScene);
	}

    //日にちのゲッター
    public int getDay()
    {
        return day;
    }
    public void SetDay(int num){
        day = num;
    }
	
    //ステータスを変化させる
    public void changeStates(JkEvent Event)
    {
		jk.changeStates(Event.getHealthValue(), Event.getInfectionValue(), Event.getStressValue());
    }
}
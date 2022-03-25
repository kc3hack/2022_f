using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
 
 
public class GameManagerNakao : MonoBehaviour
{
    //日にち
    [SerializeField] static private  int day = 1;

    //主人公のパラメータ
    [SerializeField] static private JkModel jk;
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
	
    //ステータスを変化させる
    public void changeStates(JkEvent Event)
    {

    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calendar : MonoBehaviour
{
    //日にち
    [SerializeField] private  int day;
    //イベント情報
    [SerializeField] private List<List<isGoEvent>> GaisyutuEventList = new List<List<isGoEvent>>();
    //[SerializeField] private List<List<FriendStatusValue>>   SumahoEventList = new List<List<FriendStatusValue>>();
    //[SerializeField] private List<List<JkEvent>> CalendarEventList = new List<List<JkEvent>>();

    //主人公のパラメータ
    [SerializeField] private JkModel jk;
    // Start is called before the first frame update
    void Start()
    {
        day = 1;
		Initialize();
    }

    //日にちのゲッター
    public int getDay()
    {
        return day;
    }
	
	public void setDay(int day)
	{
		this.day = day;
	}
	
	public void Initialize(){
		for(int i=0; i<31; i++){
			GaisyutuEventList.Add(new List<isGoEvent>());
			GaisyutuEventList[i].Add(new isGoEvent("Place0"));
			GaisyutuEventList[i].Add(new isGoEvent("Place1"));
			GaisyutuEventList[i].Add(new isGoEvent("Place2"));
			GaisyutuEventList[i].Add(new isGoEvent("Place8"));
		}
	}

    //イベント情報のゲッター
    public List<isGoEvent> getGaisyutuEvent()
    {
        return GaisyutuEventList[day-1];
    }
	//イベント情報のゲッター
    /*public List<FriendStatusValue> getSumahoEvent()
    {
        return SumahoEventList[day-1];
    }*/
	//イベント情報のゲッター
    /*public List<ClendarEvent> getClandarEvent()
    {
        return ClandarEventList[day-1];
    }*/

    //ステータスを変化させる
    public void changeStates(JkEvent Event)
    {
		
    }
	/*public void changeStates(int healthValue, int infectionValue, int stressValue)
    {

    }*/
}

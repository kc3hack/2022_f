using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum EventEnum {
	Empty 		= 0,
	BBQ 		= 1,
	Natumatri 	= 2,
	Camp 		= 3,
	Umi			= 4
}

public class Calendar : MonoBehaviour
{
	
    //日にち
    [SerializeField] private  int day;
    //イベント情報
    [SerializeField] private List<List<isGoEvent>> GaisyutuEventList = new List<List<isGoEvent>>();
    [SerializeField] private List<List<FriendStatusValue>> SumahoEventList = new List<List<FriendStatusValue>>();
    [SerializeField] private List<int> CalendarEventList = new List<int>();

	//表示するカレンダーのスプライト
	[SerializeField] private List<Sprite> Sprites;
	[SerializeField] private GameObject GameManager;
	private Image nowImage;

    //主人公のパラメータ
    [SerializeField] private JkModel jk;
    // Start is called before the first frame update
    void Start()
    {
        day = GameManager.GetComponent<GameManagerNakao>().getDay();
		nowImage = this.GetComponent<Image>();
		ChangeSprite();
		Initialize();
    }

    //日にちのゲッター
    public int getDay()
    {
        return day;
    }
	
	public void ChangeSprite(){
		nowImage.sprite = Sprites[day-1];
	}
	
	public void setDay(int day)
	{
		this.day = day;
		ChangeSprite();
	}
	
	public void Initialize(){
		//テストケースの作成

		for(int i=0; i<31; i++){
			GaisyutuEventList.Add(new List<isGoEvent>());
			GaisyutuEventList[i].Add(new isGoEvent("Place0"));
			GaisyutuEventList[i].Add(new isGoEvent("Place1"));
			GaisyutuEventList[i].Add(new isGoEvent("Place2"));
			GaisyutuEventList[i].Add(new isGoEvent("Place8"));
		}
		
		CalendarEventList = new List<int>() {
			0,	//（Empty）		一日目のイベント
			1,	//（Natumatri）	二日目のイベント
			2,	//（Umi）		　	三日目のイベント
			3,	//（BBQ）		　	四日目のイベント
			4,	//（Camp）　		五日目のイベント
			0,	//（Natumatri）　	六日目のイベント
			0,	//（Empty）　		
			0,	//（Empty）　		
			0,	//（Empty）　		
			0,	//（Empty）　		
			0,	//（Empty）　		
			0,	//（Empty）　		
			0,	//（Empty）　		
			0,	//（Empty）　		
			0,	//（Empty）　		
			0,	//（Empty）　		
			0,	//（Empty）　		
			0,	//（Empty）　		
			0,	//（Empty）　		
			0,	//（Empty）　		
			0,	//（Empty）　		
			0,	//（Empty）　		
			0,	//（Empty）　		
			0,	//（Empty）　		
			0,	//（Empty）　		
			0,	//（Empty）　		
			0,	//（Empty）　		
			0,	//（Empty）　		
			0,	//（Empty）　		
			0,	//（Empty）　		
			0,	//（Empty）　		三十一日目のイベント
		};
		
		for(int i=0; i<31; i++){
			List<FriendStatusValue> OneDayMessage = new List<FriendStatusValue>();
			FriendStatusValue fsv = new FriendStatusValue();
			fsv.SetName("日付ちゃん"); fsv.SetMessage($"今日は{i+1}日目やで");
			OneDayMessage.Add(fsv);
			
			SumahoEventList.Add(OneDayMessage);
		}
	}

    //イベント情報のゲッター
    public List<isGoEvent> getGaisyutuEvent()
    {
        return GaisyutuEventList[day-1];
    }
	//イベント情報のゲッター
    public List<FriendStatusValue> getSumahoEvent() //今日の友達からのメッセージを取得する
    {
        return SumahoEventList[day-1];
    }
	//イベント情報のゲッター
    public List<int> getClandarEvent()
    {
        return CalendarEventList;
    }

    //ステータスを変化させる
    public void changeStates(JkEvent Event)
    {
		
    }
	/*public void changeStates(int healthValue, int infectionValue, int stressValue)
    {

    }*/
}

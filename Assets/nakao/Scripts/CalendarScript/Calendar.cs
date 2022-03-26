using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public enum EventEnum {
	Empty 		= 0,
	BBQ 		= 1,
	Natumaturi 	= 2,
	Camp 		= 3,
	Umi			= 4
}

public class MessageAndNum{
	public string Message;
	public int EventNum;
	
	public MessageAndNum(string message, int num){
		Message = message;
		EventNum = num;
	}
}

public class MessageAndDistination{
	public List<string> name = new List<string>() {
		"アッコ",
		"さっちゃん",
		"メンヘラ子",
		"れーにゃ",
		"あめ",
		"地雷系",
		"なつき",
		"ゆき",
	};
	public List<MessageAndNum> messageAndnum = new List<MessageAndNum>() {
		new MessageAndNum("今日バーベキューいかない？", 1),
		new MessageAndNum("焼肉食べに行こう", 1),
		new MessageAndNum("今日お祭りやってるよ～", 2),
		new MessageAndNum("神輿おがみに行こうよ^^", 2),
		new MessageAndNum("今からキャンプ行こ～ :)", 3),
		new MessageAndNum("みんなで海行くけど一緒に来る？", 4),
		new MessageAndNum("海行きて～", 4),
	};
	
	public string Name;
	public string Message;
	public int EventNum;
	
	public MessageAndDistination(){
		Name = name[Random.Range(0, 8)];
		MessageAndNum MA = messageAndnum[Random.Range(0, 7)];
		Message = MA.Message;
		EventNum = MA.EventNum;
	}
}

public class Calendar : MonoBehaviour
{
	
    //日にち
    [SerializeField] private  int day;
    //イベント情報
    [SerializeField] private static List<List<isGoEvent>> GaisyutuEventList = new List<List<isGoEvent>>();
    [SerializeField] private static List<List<FriendStatusValue>> SumahoEventList = new List<List<FriendStatusValue>>();
    [SerializeField] private static List<int> CalendarEventList = new List<int>();

	//表示するカレンダーのスプライト
	[SerializeField] private List<Sprite> Sprites;
	[SerializeField] private GameObject GameManager;
	private Image nowImage;

    //主人公のパラメータ
    //[SerializeField] private static JkModel jk;
    // Start is called before the first frame update
    void Start()
    {
        day = GameManager.GetComponent<GameManagerNakao>().getDay();
		if(day == 32){
			InfectionManager IM = GameObject.Find("InfectionManager").GetComponent<InfectionManager>();
			IM.SetInfectionList( JkModel.getInfectionData() );
			SceneManager.LoadScene("Owari");
			}
		nowImage = this.GetComponent<Image>();
		ChangeSprite();
		
		if(GaisyutuEventList.Count == 0)Initialize();
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
			
			if(Random.Range(0, 2) == 0){
				int EventNum1 = Random.Range(1, 5);
				EventEnum En1 = (EventEnum)System.Enum.ToObject(typeof(EventEnum), EventNum1);
				string place1 = En1.ToString();
				GaisyutuEventList[i].Add(new isGoEvent(place1));
				CalendarEventList.Add(EventNum1);
				//Debug.Log($"{i}: {place1}");
				
				if(Random.Range(0, 5) == 3){
					int EventNum2;
					do{
						EventNum2 = Random.Range(1, 5);
					}while(EventNum1 == EventNum2);
					EventEnum En2 = (EventEnum)System.Enum.ToObject(typeof(EventEnum), EventNum2);
					string place2 = En2.ToString();
					GaisyutuEventList[i].Add(new isGoEvent(place2));
					//Debug.Log($"{i}: {place2}");
				}
			}else{
				CalendarEventList.Add(0);
			}
			
			List<FriendStatusValue> OneDayMessage = new List<FriendStatusValue>();
			if(Random.Range(0, 6) < 4){
				OneDayMessage = AddMessage(i, OneDayMessage);
				if(Random.Range(0, 6) < 2){
					OneDayMessage = AddMessage(i, OneDayMessage);
					if(Random.Range(0, 6) < 2){
						OneDayMessage = AddMessage(i, OneDayMessage);
					}
				}
			}
			SumahoEventList.Add(OneDayMessage);
		}
	}
	
	public List<FriendStatusValue> AddMessage(int i, List<FriendStatusValue> ODM){
		FriendStatusValue fsv = new FriendStatusValue();
		MessageAndDistination MAD;
		bool flag;
		do{
			flag = false;
			MAD = new MessageAndDistination();
			for(int j=0; j<ODM.Count; j++){
				if(ODM[j].GetName() == MAD.Name){
					flag = true;
					break;
				}
			}
		}while(flag);
		fsv.SetName(MAD.Name); fsv.SetMessage(MAD.Message);
		ODM.Add(fsv);
		
		EventEnum En = (EventEnum)System.Enum.ToObject(typeof(EventEnum), MAD.EventNum);
		string place = En.ToString();
		GaisyutuEventList[i].Add(new isGoEvent(place));
		//Debug.Log($"{i}: {place}");
		
		return ODM;
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
    //public void changeStates(JkEvent Event)
    //{
		
    //}
	/*public void changeStates(int healthValue, int infectionValue, int stressValue)
    {

    }*/
}

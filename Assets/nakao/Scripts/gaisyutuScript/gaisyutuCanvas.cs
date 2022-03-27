using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class isGoEvent: NakaoJkEvent{
	public string PlaceName;
	
	public isGoEvent(string PlaceName){
		this.PlaceName = PlaceName;
	}
}

public class Place{
	public string Name;
	public Vector2 Pos;
	public bool Reachable;
	public string Explanation;
	
	public Place(string name, Vector2 pos, bool reachable , string explanation){
		Name = name;
		Pos = pos;
		Reachable = reachable;
		Explanation = explanation;
	}
}

public class PlaceList{
	public List<Place> Places;
	
	public PlaceList(List<Place> places){
		Places = places;
	}
	public void AllTrue(){
		foreach(Place place in Places){
			place.Reachable = true;
		}
	}
	public void AllFalse(){
		foreach(Place place in Places){
			place.Reachable = false;
		}
	}
	public string SearchText(string name){
		foreach(Place place in Places){
			if(place.Name == name)return place.Explanation;
		}
		return "";
	}
	public void SearchAndTrue(string name){
		foreach(Place place in Places){
			if(place.Name == name){
				place.Reachable = true;
				//Debug.Log($"{place.Name} is true");
			}
		}
	}
}

public class gaisyutuCanvas : MonoBehaviour
{
	public PlaceList Placelist = new PlaceList(
		new List<Place>() {
			/*new Place("Place0", new Vector2(-525.0f,  -47.0f), false, "This is Place0 "),
			new Place("Place1", new Vector2(-265.0f, -232.0f), false, "This is Place1 "),
			new Place("Place2", new Vector2(  20.0f, -467.0f), false, "This is Place2 "),
			new Place("Place3", new Vector2(-233.0f,  139.0f), false, "This is Place3 "),
			new Place("Place4", new Vector2(  16.0f,   28.0f), false, "This is Place4 "),
			new Place("Place5", new Vector2( 292.0f, -254.0f), false, "This is Place5 "),
			new Place("Place6", new Vector2(  12.0f,  438.0f), false, "This is Place6 "),
			new Place("Place7", new Vector2( 274.0f,  180.0f), false, "This is Place7 "),
			new Place("Place8", new Vector2( 550.0f,  -46.0f), false, "This is Place8 "),
			new Place("Place9", new Vector2(-525.0f,  -47.0f), false, "This is Place9 "),*/
			
			new Place("Umi", new Vector2(-400.0f,  70.0f), false, "晴れの日に栄えると\nSNSで人気のビーチ"),
			new Place("Natumaturi", new Vector2(330.0f, -260.0f), false, "割と頻繁に\n鮮やかな祭りが\n開かれる通り"),
			new Place("Camp", new Vector2(  0.0f, 70.0f), false, "格安で楽しめる\n隠れた穴場キャンプ場"),
			new Place("BBQ", new Vector2(510.0f,  350.0f), false, "推ししの配信者の\nお気に入りの\nバーベキュー会場"),
		}
	);
	
	[SerializeField] private GameObject ButtonPrefab;
	[SerializeField] private GameObject CalendarObj;
	[SerializeField] private Sprite BBQicon, Natumaturiicon,Umiicon, Campicon;
	//[SerializeField] private float	scale = 0.007f;
	[SerializeField] private float	scale = 1f;
	private Calendar CalendarScript;
	
	public void Start(){
		//CalendarScript = GameObject.Find("CalendarObj").GetComponent<Calendar>();
	}
	
    // Start is called before the first frame update
    public void Initialize()
    {
		CalendarScript = CalendarObj.GetComponent<Calendar>();
		var EventList = CalendarScript.getGaisyutuEvent();

		foreach(var Event in EventList){
			//Debug.Log($"search and true at {Event.PlaceName}");
			Placelist.SearchAndTrue(Event.PlaceName);
		}
		
		Transform ImageTf = transform.Find("MapImage");
		Vector2 tp = ImageTf.gameObject.GetComponent<Transform>().position;
		GoButton GoButtonScript = transform.Find("GoImage/GoButton").GetComponent<GoButton>();
		
		foreach(Place place in Placelist.Places){
			if(!place.Reachable)continue;
			
			GameObject ObjButton = (GameObject)Instantiate(ButtonPrefab, place.Pos*scale+tp, Quaternion.identity);
			ObjButton.transform.SetParent(ImageTf);
			ObjButton.name = place.Name;
			switch(ObjButton.name){
				case "Umi":
					ObjButton.GetComponent<Image>().sprite = Umiicon;
					break;
					
				case "Natumaturi":
					ObjButton.GetComponent<Image>().sprite = Natumaturiicon;
					break;
					
				case "BBQ":
					ObjButton.GetComponent<Image>().sprite = BBQicon;
					break;
					
				case "Camp":
					ObjButton.GetComponent<Image>().sprite = Campicon;
					break;
			}
			SelectButton Script = ObjButton.GetComponent<SelectButton>();
			Script.ExplanationText = GameObject.Find("Explanation").GetComponent<Text>();
			Script.ExplanationString = place.Explanation;
			Script.GoButtonScript = GoButtonScript;
		}
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
}

public class gaisyutuCanvas : MonoBehaviour
{
	public PlaceList Placelist = new PlaceList(
		new List<Place>() {
			new Place("Place0", new Vector2(-525.0f,  -47.0f), true, "This is Place0 "),
			new Place("Place1", new Vector2(-265.0f, -232.0f), true, "This is Place1 "),
			new Place("Place2", new Vector2(  20.0f, -467.0f), true, "This is Place2 "),
			new Place("Place3", new Vector2(-233.0f,  139.0f), true, "This is Place3 "),
			new Place("Place4", new Vector2(  16.0f,   28.0f), true, "This is Place4 "),
			new Place("Place5", new Vector2( 292.0f, -254.0f), true, "This is Place5 "),
			new Place("Place6", new Vector2(  12.0f,  438.0f), true, "This is Place6 "),
			new Place("Place7", new Vector2( 274.0f,  180.0f), true, "This is Place7 "),
			new Place("Place8", new Vector2( 550.0f,  -46.0f), true, "This is Place8 "),
			new Place("Place9", new Vector2(-525.0f,  -47.0f), true, "This is Place9 "),
		}
	);
	
	[SerializeField] private GameObject ButtonPrefab;
    // Start is called before the first frame update
    public void Initialize()
    {
		Vector2 tp = this.transform.position;
		
		foreach(Place place in Placelist.Places){
			if(!place.Reachable)continue;
			
			GameObject ObjButton = (GameObject)Instantiate(ButtonPrefab, place.Pos+tp, Quaternion.identity);
			ObjButton.transform.SetParent(this.transform);	
			ObjButton.name = place.Name;
			SelectButton Script = ObjButton.GetComponent<SelectButton>();
			Script.ExplanationText = GameObject.Find("Explanation").GetComponent<Text>();
			Script.ExplanationString = place.Explanation;
		}
    }
}

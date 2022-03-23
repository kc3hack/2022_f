using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectButton : MonoBehaviour
{
	public Text ExplanationText;
	public string ExplanationString;
	public GoButton GoButtonScript;
	
	public void OnClick(){
		ExplanationText.text = ExplanationString;
		GoButtonScript.Destination = this.name;
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectButton : MonoBehaviour
{
	public Text ExplanationText;
	public string ExplanationString;
	
	public void OnClick(){
		ExplanationText.text = ExplanationString;
	}
}

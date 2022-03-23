using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CalenderButton : MonoBehaviour
{
    [SerializeField] private Canvas calender;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        Debug.Log("sumaho");
        calender.gameObject.SetActive(true);
    }
}

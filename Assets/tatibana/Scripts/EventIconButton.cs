using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventIconButton : MonoBehaviour
{
    [SerializeField] private Image whiteBoxImage;

    [SerializeField] private Text whiteBoxText;

    [SerializeField] private Sprite eventImage;

    [SerializeField] private string eventText;

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
        whiteBoxImage.sprite = eventImage;

        whiteBoxText.text = eventText;
    }
}

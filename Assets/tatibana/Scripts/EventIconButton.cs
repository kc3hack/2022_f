using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventIconButton : MonoBehaviour
{
    [SerializeField] private Image whiteBoxImage;

    [SerializeField] private Text whiteBoxText;

    //[SerializeField] private Sprite eventImage;

    [SerializeField] private string eventText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setSprite(Sprite sprite)
    {
        this.GetComponent<Image>().sprite = sprite;
    }

    public void setText(string text)
    {
        eventText = text;
    }

    public void OnClick()
    {
        whiteBoxImage.sprite = this.GetComponent<Image>().sprite;

        whiteBoxText.text = eventText;
    }
}

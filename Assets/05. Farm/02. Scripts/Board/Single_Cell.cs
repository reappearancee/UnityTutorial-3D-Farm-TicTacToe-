using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Single_Cell : MonoBehaviour
{
    public int x, y;
    [SerializeField] Button button;
    [SerializeField] TextMeshProUGUI cellText;

    void Awake()
    {
        button = GetComponent<Button>();
        cellText = GetComponent<TextMeshProUGUI>();
    }

    public void SetText(string text)
    {
        cellText.text = text;
    }

    public void SetButton(int x, int y, Action<int,int> onClickEvent)
    {
        this.x = x;
        this.y = y;
        
        button.onClick.AddListener(() => onClickEvent(x,y));
    }
}

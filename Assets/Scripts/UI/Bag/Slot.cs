using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// 背包格子
/// </summary>
public class Slot : MonoBehaviour 
{
    public string slotname;
    public Image image;
    [TextArea]public string slotInfo;

    public GameObject InfoObj;

    private void Start()
    {
        InfoObj = GameObject.Find("ShowInfoPanel");
        ShowInfo();
    }
    public void OnMouseEnter()
    {
        ShowInfo();
    }
    /// <summary>
    /// 展示面板信息
    /// </summary>
    public void ShowInfo()
    {
        InfoObj.transform.Find("ItemName").GetComponent<Text>().text = slotname;
        InfoObj.transform.Find("Image").GetComponent<Image>().sprite = image.sprite;
        InfoObj.transform.Find("Description").GetComponent<Text>().text = slotInfo;
    }
}

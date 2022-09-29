using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// ±³°ü¸ñ×Ó
/// </summary>
public class Slot : MonoBehaviour 
{
    public string slotname;
    public Image image;
    [TextArea]public string slotInfo;

    public GameObject textObj;

    private void OnEnable()
    {
        textObj = transform.Find("Text").gameObject;
        textObj.SetActive(false);
    }
    private void OnMouseEnter()
    {
        textObj.SetActive(true);
        Debug.Log(1);
    }
    private void OnMouseExit()
    {
        textObj.SetActive(false);
        Debug.Log(2);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMgr : SingletonMono<UIMgr>
{
    public GameObject BaseCanves;

    public GameObject _panel;
    public Text _text;

    public IEnumerator Showpanel(string showName)
    {
        if (_panel.activeInHierarchy)
        {
            _panel.SetActive(false);
        }
        _panel.SetActive(true);
        _text.text = $"������{showName}";
        yield return new WaitForSeconds(2f);
        _panel.SetActive(false);
    }
    public void ShowPanel(string showname)
    {
        StartCoroutine(Showpanel(showname));
    }
}

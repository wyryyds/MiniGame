using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMgr : SingletonMono<UIMgr>
{
    public GameObject BaseCanves;

    public GameObject _panel;
    public Text _text;
    
    /// <summary>
    /// ��ȡ���ߵ�UI��ʾ
    /// </summary>
    /// <param name="showname"></param>
    public void ShowPanel(string showname)
    {
        StartCoroutine(Showpanel(showname));
    }
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
}

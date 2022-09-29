using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/// <summary>
/// 可交互道具
/// </summary>
public class Item : MonoBehaviour
{
    public ItemData dataInfo;

    private void OnMouseDown()
    {
        if(Input.GetMouseButtonDown(0))
        {
            BagMgr.Instance.AddItem(gameObject);
            Destroy(gameObject);
            UIMgr.Instance.ShowPanel(name);
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// �ɽ�������
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
        }
    }
}

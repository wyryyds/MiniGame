using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BagMgr : SingletonMono<BagMgr>
{
    public Dictionary<string, ItemData> itemDic;
    public GameObject Bag;
    public GameObject Gird;
    public Slot slot;
    private void Start()
    {
        itemDic = new Dictionary<string, ItemData>();
    }
    /// <summary>
    /// 添加物品到背包
    /// </summary>
    /// <param name="obj"></param>
    public void AddItem(GameObject obj)
    {
        var itemData = obj.GetComponent<Item>().dataInfo;
        var name = itemData.itemName;
        if(!itemDic.ContainsKey(name)) itemDic.Add(name, itemData);

        var newObj = Instantiate(Instance.slot, Instance.Gird.transform);
        newObj.name = name;
        newObj.image.sprite = itemData.itemImage;
        newObj.slotInfo = itemData.itemInfo;
    }
}

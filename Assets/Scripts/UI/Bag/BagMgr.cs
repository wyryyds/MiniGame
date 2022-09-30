using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BagMgr : SingletonMono<BagMgr>
{
    public Dictionary<string, ItemData> itemDic;
    public GameObject Bag;
    public GameObject Gird;
    public GameObject showInfoPanel;
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
        var name = itemData.itemEnglishName;
        if(!itemDic.ContainsKey(name)) itemDic.Add(name, itemData);

        var newObj = Instantiate(Instance.slot, Instance.Gird.transform);
        newObj.name = name;
        newObj.slotname = itemData.itemChineseName;
        newObj.image.sprite = itemData.itemImage;
        newObj.slotInfo = itemData.itemInfo;
    }
    /// <summary>
    /// 打开背包
    /// </summary>
    public void OpenBag()
    {
        Instance.Bag.SetActive(true);
    }
    /// <summary>
    /// 关闭背包
    /// </summary>
    public void CloseBag()
    {
        Instance.Bag.SetActive(false);
    }
    
}

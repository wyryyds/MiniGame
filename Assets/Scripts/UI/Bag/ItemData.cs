using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 道具信息
/// </summary>
[CreateAssetMenu(fileName = "New Item")]
public class ItemData : ScriptableObject
{
    public string itemEnglishName;
    public string itemChineseName;
    public Sprite itemImage;
    [TextArea]
    public string itemInfo;
}

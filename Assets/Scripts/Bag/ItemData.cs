using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ������Ϣ
/// </summary>
[CreateAssetMenu(fileName = "New Item")]
public class ItemData : ScriptableObject
{
    public string itemName;
    public Sprite itemImage;
    [TextArea]
    public string itemInfo;
}

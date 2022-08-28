using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/ItemProfile")]
public class ItemProfile : ScriptableObject
{
    public ItemCode itemCode;
    public ItemType itemType;
    public Sprite itemSprite;
    public string itemName;
    public string itemDescription;
    public int itemMax = 99;
}

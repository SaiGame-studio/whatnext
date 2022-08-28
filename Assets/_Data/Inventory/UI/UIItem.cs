using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIItem : MonoBehaviour
{
    public Item item;
    public TextMeshProUGUI itemName;
    public Image itemImage;
    public TextMeshProUGUI itemNumber;

    public virtual void SetItem(Item item)
    {
        this.item = item;
        if (this.itemName) this.itemName.text = this.item.itemProfile.itemName;
        if (this.itemNumber) this.itemNumber.text = this.item.count.ToString();
        if (this.itemImage) this.itemImage.sprite = this.item.itemProfile.itemSprite;
    }
}

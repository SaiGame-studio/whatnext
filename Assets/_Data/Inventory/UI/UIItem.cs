using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIItem : MonoBehaviour
{
    public Item item;
    public TextMeshProUGUI itemName;
    public TextMeshProUGUI itemNumber;

    public virtual void SetItem(Item item)
    {
        this.item = item;
        this.itemName.text = this.item.name;
        this.itemNumber.text = this.item.count.ToString();
    }
}

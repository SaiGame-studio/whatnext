using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<Item> items;

    private void Start()
    {
        //this.Add(ItemCode.glove_1, 1);
        //this.Add(ItemCode.sword_1, 3);
        //this.Add(ItemCode.sword_2, 6);
    }

    private void Reset()
    {
        this.LoadItems();
    }

    protected virtual void LoadItems()
    {
        Item item;
        foreach (Transform child in transform)
        {
            item = child.GetComponent<Item>();
            this.items.Add(item);
        }
    }

    public virtual void Add(ItemCode itemCode,int count = 1)
    {
        Item item = this.Get(itemCode);
        if (item == null) return;
        int newCount = item.count + count;
        if (newCount > item.itemProfile.itemMax) return;
        item.count = newCount;
    }

    public virtual Item Get(ItemCode itemCode)
    {
        return this.items.Find((item) => item.itemProfile.itemCode == itemCode);
    }
}

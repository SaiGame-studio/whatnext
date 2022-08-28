using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIInentory : MonoBehaviour
{
    public Inventory inventory;
    public Transform content;
    public UIItem uiItemPrefab;

    private void OnEnable()
    {
        this.ShowInventory();
    }

    protected virtual void ShowInventory()
    {
        this.ClearContent();

        UIItem uiItem;
        foreach(Item item in this.inventory.items)
        {
            uiItem = this.createUIItem(item);
            uiItem.transform.SetParent(this.content);
        }
    }

    protected virtual void ClearContent()
    {
        foreach(Transform child in this.content)
        {
            Destroy(child.gameObject);
        }
    }

    protected virtual UIItem createUIItem(Item item)
    {
        UIItem uiItem = Instantiate(this.uiItemPrefab) as UIItem;
        uiItem.SetItem(item);
        return uiItem;
    }
}

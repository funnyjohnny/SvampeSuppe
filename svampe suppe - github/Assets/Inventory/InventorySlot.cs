using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
    public Image icon;
    public Button RemoveButton;

    Item item;

    public void AddItem (Item newItem)
    {
        item = newItem;

        icon.sprite = item.icon;
        icon.enabled = true;
        RemoveButton.interactable = true;
    }


    public void ClearSlot()
    {
        item = null;

        icon.sprite = null;
        icon.enabled = false;
        RemoveButton.interactable = false;
    }


    public void OnRemoveButton()
    {
        Inventory.instance.Remove(item);
    }


}

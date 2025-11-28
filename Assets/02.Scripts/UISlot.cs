using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UISlot : MonoBehaviour
{
    [SerializeField] private Image icon;
    private Sprite iconSprite;

    private Item curItem;

    public void SetItem(Item item)
    {
        curItem = item;
        RefreshUI();
    }

    public void RefreshUI()
    {
        if (curItem == null)
        {
            icon.enabled = false;
        }

        icon.enabled = true;
        icon.sprite = curItem.Icon;
    }
}

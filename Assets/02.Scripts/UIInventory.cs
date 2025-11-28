using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI curQuantity_Text;
    [SerializeField] private TextMeshProUGUI maxQuantity_Text;

    [SerializeField] private Transform slotParent;
    [SerializeField] private UISlot uiSlot;
    private List<UISlot> slots = new List<UISlot>();

    [SerializeField] private Button back_Btn;

    UIManager uiManager;

    private void Start()
    {
        uiManager = UIManager.Instance;

        back_Btn.onClick.AddListener(uiManager.UIMainMenu.OpenMainMenu);
        InitInventoryUI();
    }

    public void InitInventoryUI()
    {
        foreach (Transform child in slotParent)
            Destroy(child.gameObject);

        slots.Clear();

        for (int i = 0; i < GameManager.Instance.player.Inventory.Count; i++)
        {
            UISlot newSlot = Instantiate(uiSlot, slotParent);
            newSlot.SetItem(GameManager.Instance.player.Inventory[i]);

            slots.Add(newSlot);
        }

        curQuantity_Text.text = slots.Count.ToString();
        maxQuantity_Text.text = "100";
    }
}

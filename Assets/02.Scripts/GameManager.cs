using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public Character player;

    UIManager uiManager;

    [Header("test item icon")]
    [SerializeField] private Sprite swordIcon;
    [SerializeField] private Sprite armorIcon;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    private void Start()
    {
        uiManager = UIManager.Instance;

        SetData();
    }

    public void SetData()
    {
        Item sword = new Item("Sword", swordIcon);
        Item armor = new Item("Armor", armorIcon);

        List<Item> itemList = new List<Item>
        {
            sword,
            armor
        };

        player = new Character("Chad", 10, 20000, 35, 40, 100, itemList);

        uiManager.UIMainMenu.SetData(player);
        uiManager.UIStatus.SetData(player);
        uiManager.UIInventory.InitInventoryUI();
    }
}

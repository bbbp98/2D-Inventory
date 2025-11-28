using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.Progress;

public class Character
{
    public string Id { get; private set; }
    public int Level { get; private set; }
    public int Gold { get; private set; } 

    public int Attack { get; private set; } 
    public int Defense { get; private set; }
    public int Health { get; private set; }

    public List<Item> Inventory { get; private set; }
    public Item EquippedItem { get; private set; }

    public Character(string id, int level, int gold, int attack, int defense, int health, List<Item> inventory)
    {
        Id = id;
        Level = level;
        Gold = gold;

        Attack = attack;
        Defense = defense;
        Health = health;
        Inventory = inventory;
    }

    public void AddItem(Item item)
    {
        Inventory.Add(item);
    }

    public void Equip(Item item)
    {
        EquippedItem = item;
        Debug.Log($"{item.Name}이 장착되었습니다");
    }

    public void UnEquip()
    {
        if (EquippedItem == null)
            return;

        Debug.Log($"{EquippedItem.Name}이 해제되었습니다");
        EquippedItem = null;
    }
}

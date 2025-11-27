using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI curQuantity_Text;
    [SerializeField] private TextMeshProUGUI maxQuantity_Text;

    [SerializeField] private Transform inventoryContent;
    [SerializeField] private GameObject inventorySlot;

    [SerializeField] private Button back_Btn;
}

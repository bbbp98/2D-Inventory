using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance { get; private set; }

    [field:SerializeField] public UIMainMenu UIMainMenu { get; private set; }
    [field:SerializeField] public UIStatus UIStatus { get; private set; }
    [field:SerializeField] public UIInventory UIInventory { get; private set; }

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIStatus : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI attack_Text;
    [SerializeField] private TextMeshProUGUI defence_Text;
    [SerializeField] private TextMeshProUGUI health_Text;

    [SerializeField] private Button back_Btn;

    UIManager uiManager;

    private void Start()
    {
        uiManager = UIManager.Instance;

        back_Btn.onClick.AddListener(uiManager.UIMainMenu.OpenMainMenu);
    }

    public void SetData(Character player)
    {
        attack_Text.text = player.Attack.ToString();
        defence_Text.text = player.Defense.ToString();
        health_Text.text = player.Health.ToString();    
    }
}

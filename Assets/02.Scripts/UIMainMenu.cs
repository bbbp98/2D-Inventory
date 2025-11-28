using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI id_Text;
    [SerializeField] private TextMeshProUGUI playerLv_Text;
    [SerializeField] private TextMeshProUGUI gold_Text;

    [SerializeField] private Button status_Btn;
    [SerializeField] private Button inventory_Btn;

    UIManager uiManager;

    private void Start()
    {
        uiManager = UIManager.Instance;

        status_Btn.onClick.AddListener(OpenStatus);
        inventory_Btn.onClick.AddListener(OpenInventory);

        OpenMainMenu();
    }

    public void OpenMainMenu()
    {
        SetActiveButtons(true);
        uiManager.UIStatus.gameObject.SetActive(false);
        uiManager.UIInventory.gameObject.SetActive(false);
    }

    public void OpenStatus()
    {
        SetActiveButtons(false);
        uiManager.UIStatus.gameObject.SetActive(true);
    }

    public void OpenInventory()
    {
        SetActiveButtons(false);
        uiManager.UIInventory.gameObject.SetActive(true);
    }

    public void SetActiveButtons(bool active)
    {
        status_Btn.gameObject.SetActive(active);
        inventory_Btn.gameObject.SetActive(active);
    }

    public void SetData(Character player)
    {
        id_Text.text = player.Id;
        playerLv_Text.text = player.Level.ToString();
        gold_Text.text = player.Gold.ToString();
    }
}

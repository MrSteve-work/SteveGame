using UnityEngine;
using TMPro; // Подключаем TextMeshPro

public class BlueDiamondManager : MonoBehaviour
{
    public static BlueDiamondManager instance; // Доступ из любого скрипта
    public TextMeshProUGUI DiamondText;
    private int totalDiamond = 0;

    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void AddCoins(int amount)
    {
        totalDiamond = totalDiamond + amount;
        UpdateUI();
    }

    private void UpdateUI()
    {
        if (DiamondText != null)
        {
            DiamondText.text = totalDiamond + "";
        }
    }

}
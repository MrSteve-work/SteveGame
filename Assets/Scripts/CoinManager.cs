using UnityEngine;
using TMPro; // Подключаем TextMeshPro

public class CoinManager : MonoBehaviour
{
    public static CoinManager instance; // Доступ из любого скрипта
    public TextMeshProUGUI coinText;
    private int totalCoin = 0;

    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void AddCoins(int amount)
    {
        totalCoin = totalCoin + amount;
        UpdateUI();
    }

    private void UpdateUI()
    {
        if (coinText != null)
        {
            coinText.text = totalCoin + ""; 
        }
    }

}
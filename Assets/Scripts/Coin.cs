using UnityEngine;

public class Coin : MonoBehaviour
{
    private int coinValue = 1; // Количество очков за Coin

    // Когда срабатывает скрипт
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            // Добовляем монетку в UI
            if(CoinManager.instance != null)
            {
                CoinManager.instance.AddCoins(coinValue);
            }
            // Уничтожить Coin
            Destroy(gameObject);
        }
    }
}

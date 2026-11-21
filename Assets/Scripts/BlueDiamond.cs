using UnityEngine;

public class BlueDiamond : MonoBehaviour
{
    private int DiamondValue = 1; // Количество очков за Diamond

    // Когда срабатывает скрипт
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            // Добовляем Diamond в UI
            if (BlueDiamondManager.instance != null)
            {
                BlueDiamondManager.instance.AddCoins(DiamondValue);
            }
            // Уничтожить Diamond
            Destroy(gameObject);
        }
    }
}

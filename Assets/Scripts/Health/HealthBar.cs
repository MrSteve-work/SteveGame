using UnityEngine;
using UnityEngine.UI;
public class HealthBar : MonoBehaviour
{
    public Health playerHealth;
    public Image currentHelthBar;

    private void Start()
    {
        currentHelthBar.fillAmount = playerHealth.currentHealth / 10;
    }

    private void Update()
    {
        currentHelthBar.fillAmount = playerHealth.currentHealth / 10;
    }
}

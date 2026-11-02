using UnityEngine;

public class Health : MonoBehaviour
{
    public float startingHealth; // Количество жизней
    public float currentHealth; // Количество жизней в данный момент
    private bool dead;
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
        currentHealth = startingHealth;
    }


    public void TakeDamage(float _damage) // Получение урона
    {
        currentHealth = Mathf.Clamp(currentHealth - _damage, 0, startingHealth);
    }

    public void AddHealth(float _add)
    {
        currentHealth = Mathf.Clamp(currentHealth + _add, 0, startingHealth);
    }
}
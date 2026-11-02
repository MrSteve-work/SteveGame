using UnityEngine;

public class Medicament : MonoBehaviour
{
    public float add;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            collision.GetComponent<Health>().AddHealth(add);
            Destroy(gameObject);
        }
    }
}

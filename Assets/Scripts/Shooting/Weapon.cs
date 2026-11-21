using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Weapon : MonoBehaviour
{
    public Transform shotpos;
    public GameObject Bullet;
    public float fireRate = 0.3f;
    private float nextFireTime = 0f;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.F) && Time.time >= nextFireTime)
        {
            Instantiate(Bullet, shotpos.transform.position, transform.rotation);
            nextFireTime = Time.time + fireRate;
        }
    }
}

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Weapon : MonoBehaviour
{
    public Transform shotpos;
    public GameObject Bullet;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            Instantiate(Bullet, shotpos.transform.position, transform.rotation);
        }
    }
}

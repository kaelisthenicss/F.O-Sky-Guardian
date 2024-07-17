using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject bulletPrefab;
    

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
           Instantiate(bulletPrefab, transform.position, transform.rotation);
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform bulletRotation;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
           Instantiate(bulletPrefab, transform.position, bulletRotation.rotation);
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {

    public Transform firePoint;
    public GameObject bulletPrefab;
    public float fireRate = 0.5f;
    private float nextFire = 0.0f;
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0) && Time.time > nextFire) 
        {
            Shoot();
            nextFire = Time.time + fireRate;
          

        }
	} void Shoot()
    {
        //shooting logic
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

    }
}

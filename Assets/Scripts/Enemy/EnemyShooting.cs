using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bullet;
    public Transform bulletSpawn;
    public float fireRate = 5;
    void Start()
    {
        InvokeRepeating("Fire", fireRate, fireRate);
    }

    // Update is called once per frame
    void Fire(){
        Instantiate(bullet, bulletSpawn.position, bulletSpawn.rotation);
    }
}

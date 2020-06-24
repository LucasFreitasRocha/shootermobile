using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody rb;
    public float speed = 10;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Start()
    {
        rb.velocity = transform.forward * speed ;
    }
    private void OnCollisionEnter(Collision other) {
        Destroy(gameObject);
    }

    // Update is called once per frame
}

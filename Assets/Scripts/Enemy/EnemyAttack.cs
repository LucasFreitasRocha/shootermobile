using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject damageImpact;
    public float attackRate = 1;
    public int damage = 10;
    public PlayerHealth playerHealth;

    private GameObject player;
    private bool playerInRange;
    private float timer;
    void Start()
    {
        player = FindObjectOfType<PlayerMovement>().gameObject;
        playerHealth = player.GetComponent<PlayerHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > attackRate && playerInRange)
        {
            Attack();
        }
    }
    public void StartAttack()
    {
        damageImpact.SetActive(true);
    }
    public void FinishAttack()
    {
        damageImpact.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            playerInRange = true;
        }
    }
    void Attack()
    {
        timer = 0;
        playerHealth.Takedamage(damage, Vector3.zero);
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == player)
        {
            playerInRange = false;
        }
    }
}

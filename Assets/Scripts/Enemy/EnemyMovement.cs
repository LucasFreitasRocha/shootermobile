using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    // Start is called before the first frame update
    private NavMeshAgent nav;
    private Transform player;
    private void Awake() {
        nav = GetComponent<NavMeshAgent>();
        
    }
    private void Start() {
        player = FindObjectOfType<PlayerMovement>().transform;
        /* player = GameObject.Find("Player").transf  */
    }

    // Update is called once per frame
    void Update()
    {
        nav.SetDestination(player.position);
    }
}

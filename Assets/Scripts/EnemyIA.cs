using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyIA : MonoBehaviour
{
    public Transform player;
    private Rigidbody2D rb;
    private Vector2 movement;
    public float moveSpeed = 3f;
    NavMeshAgent agent;


    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
    }

    // Update is called once per frame
    void Update()
    {
        processInput();
        agent.SetDestination(player.position);

    }

    private void FixedUpdate() {
        //moveEnemy();
    }


    void processInput(){
        movement = new Vector2(player.position.x - transform.position.x, player.position.y - transform.position.y).normalized;
        float angle = Mathf.Atan2(movement.y, movement.x) * Mathf.Rad2Deg;
        rb.rotation = angle;
    }

    void moveEnemy(){
        rb.velocity = new Vector2 (movement.x * moveSpeed , movement.y * moveSpeed);
    }
}

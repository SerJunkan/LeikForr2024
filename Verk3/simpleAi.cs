/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class simpleAi : MonoBehaviour
{
    public NavMeshAgent agent;

    public Transform player;

    public LayerMask WhatIsGround, Whatisplayer;

    //basic patrol
    public Vector3 WalkPoint;
    bool WalkPointSet;
    public float WalkPointRange;

    //basic attack
    public float TimeBetweeenAttacks;
    bool AlreadyAttacked;

    //States
    public float SightRange, AttackRange;
    public bool PlayerIsInRange, PlayerInAttackRange;


    public float health;

    public GameObject projectile;


    private void Awake()
    {
        player = GameObject.Find("First Person Controller").transform;
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        //leitar af player
        PlayerIsInRange = Physics.CheckSphere(transform.position, SightRange, Whatisplayer);
        PlayerInAttackRange = Physics.CheckSphere(transform.position, AttackRange, Whatisplayer);

        if (!PlayerIsInRange && !PlayerInAttackRange) Patroling();
        if (PlayerIsInRange && !PlayerInAttackRange) ChasePlayer();
        if (PlayerIsInRange && PlayerInAttackRange) AttackPlayer();
    }

    private void Patroling()
    {
        if (!WalkPointSet) SearchWalkPoint();

        if (WalkPointSet)
            agent.SetDestination(WalkPoint);

        Vector3 distanceToWalkPoint = transform.position - WalkPoint;

        //Walkpoint reached
        if (distanceToWalkPoint.magnitude < 1f)
            WalkPointSet = false;
    }

    private void SearchWalkPoint()
    {
        //Calculate random point in range
        float randomZ = Random.Range(-WalkPointRange, WalkPointRange);
        float randomX = Random.Range(-WalkPointRange, WalkPointRange);

        WalkPoint = new Vector3(transform.position.x + randomX, transform.position.y, transform.position.z + randomZ);

        if (Physics.Raycast(WalkPoint, -transform.up, 2f, WhatIsGround))
            WalkPointSet = true;
    }

    private void ChasePlayer()
    {
        agent.SetDestination(player.position);
    }

    private void AttackPlayer()
    {
        //Make sure enemy doesn't move
        agent.SetDestination(transform.position);

        transform.LookAt(player);

        if (!AlreadyAttacked)
        {
            ///Attack code here
            Rigidbody rb = Instantiate(projectile, transform.position, Quaternion.identity).GetComponent<Rigidbody>();
            rb.AddForce(transform.forward * 32f, ForceMode.Impulse);
            rb.AddForce(transform.up * 8f, ForceMode.Impulse);
            ///End of attack code

            AlreadyAttacked = true;
            Invoke(nameof(ResetAttack), TimeBetweeenAttacks);
        }
    }

    private void ResetAttack()
    {
        AlreadyAttacked = false;
    }

    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0) Invoke(nameof(DestroyEnemy), 0.5f);
    }
    private void DestroyEnemy()
    {
        Destroy(gameObject);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, AttackRange);
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, SightRange);
    }

}
*/
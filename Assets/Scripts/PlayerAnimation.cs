using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Player))]

public class PlayerAnimation : MonoBehaviour
{
    // ToDo: This script needs a reference variable for each component:
    Rigidbody2D rigidbody;
    Player player;
    Animator animator;

    public GameObject particlePrefab;
    // Start is called before the first frame update
    void Start()
    {
        // ToDo: Get a reference to each component using GetComponent
        rigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        player = GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool("Falling", player.isFalling);
        animator.SetFloat("YVelocity", rigidbody.velocity.y);
    }
    public void Smoke() 
    {
        Instantiate(particlePrefab, transform.position, Quaternion.identity);
    }
}

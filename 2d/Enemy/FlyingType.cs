using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFlyingType : MonoBehaviour
{

    public Transform playerPos;

    Rigidbody2D rb;

    public float moveSpeed;

    public Vector2 test;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {

        test = rb.velocity;

        float angle = Mathf.Atan2(playerPos.position.y, playerPos.position.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(new Vector3(0, 0, angle - 90)), 0.25f);

        rb.velocity = new Vector2(transform.forward.x * moveSpeed, transform.forward.y * moveSpeed);

    }
}



using System.Collections;
using UnityEngine;


public class EnemyWalkingType : MonoBehaviour
{

    public GameObject player;

    public static Rigidbody2D rb;
    public int speed;
   


    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
  
    private void FixedUpdate()
    {
    
        EnemyMove();
      
    }

    void EnemyMove()
    {
        if (transform.position.x >= player.transform.position.x)
            rb.velocity = new Vector2(-speed, rb.velocity.y);
        else
            rb.velocity = new Vector2(speed, rb.velocity.y);
    }


   
}

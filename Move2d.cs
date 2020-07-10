using UnityEngine;

public class Move2d : MonoBehaviour
{
    Rigidbody2D rb;
    float x;

    public float jumpHight;
    public float checkForGroundDistance;

    bool Sprint;
    public bool grounded;

    SpriteRenderer renderer;
   



    public LayerMask whatIsGround;

    public float walkSpeed, sprintSpeed;

    bool flipX;

    private void Awake()
    {
        renderer = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        grounded = true;
    }

    private void Update()
    {
        x = Input.GetAxis("Horizontal");

        if (Input.GetKey(KeyCode.LeftShift))
            Sprint = true;
        else
            Sprint = false;

        if (grounded && Input.GetKeyDown(KeyCode.Space))
            Jump();

        CollisionDetection();

        FlipDetection();
    }

    void FlipDetection()
    {
        flipX = renderer.flipX;

        if (Input.GetKeyDown(KeyCode.D))
            renderer.flipX = false;
        else if (Input.GetKeyDown(KeyCode.A))
            renderer.flipX = true;
        else
            return;
    }

 

    void CollisionDetection()
    {
        Collider2D collider2D = GetComponent<Collider2D>();

        grounded = collider2D.IsTouchingLayers(whatIsGround);

    }

    void Jump()
    {
        rb.AddForce(transform.up * jumpHight, ForceMode2D.Impulse);
    }

    private void FixedUpdate()
    {
        if(!Sprint)
          rb.velocity = new Vector2(x * walkSpeed, rb.velocity.y);
        else
            rb.velocity = new Vector2(x * sprintSpeed, rb.velocity.y);



    }
}

using UnityEngine;

public class playerMouvement : MonoBehaviour
{
    public Rigidbody2D rb;

    public float movedirectionX = 0;

     public float moveSpeed = 10;

    public float jumpForce = 7;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movedirectionX = Input.GetAxis("Horizontal");
    }

    private void Jump () {
           rb.linearVelocity = new Vector2 (
            rb.linearVelocity.x,
            jumpForce
           );
    }

    private void FixedUpdate ()  {
       rb.linearVelocity = new Vector2 (
        movedirectionX * moveSpeed,
        rb.linearVelocity.y

       );
    }
}

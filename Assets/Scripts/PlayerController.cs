using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D theRD;
    public float moveSpeed;
    public float jumpForce;
    public Transform groundPoint;
    private bool isOnGround;
    public LayerMask whatIsGround;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        theRD.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * moveSpeed, theRD.velocity.y);

        isOnGround = Physics2D.OverlapCircle(groundPoint.position, .2f, whatIsGround);

        if(Input.GetButtonDown("Jump") && isOnGround)
        {
            theRD.velocity = new Vector2(theRD.velocity.x, jumpForce);
        }
    }
}

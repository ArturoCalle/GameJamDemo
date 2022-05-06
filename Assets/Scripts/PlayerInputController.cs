using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputController : MonoBehaviour
{
    private float gravity = -9.81f, terminalVelocity = -25f;

    public static PlayerInputController instance;
    public Animator animator;

    //Constant speeds
    public float moveSpeed;
    public float jumpForce;

    private Vector2 moveDirection;
    private Rigidbody2D rigidbody2D;

    public bool grounded;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        rigidbody2D = GetComponent<Rigidbody2D>();
        moveDirection = new Vector2(0,0);   
    }

    // Update is called once per frame
    void Update()
    {
        if(SceneController.instance.state == GameState.PLAYING)
        {
            getInputs();
            locomotion();
        }
    }

    public void getInputs()
    {
        if (Input.GetKey(KeyCode.A))
        {
            
            if (Input.GetKey(KeyCode.D))
                moveDirection.x += 0;
            else
            {
                moveDirection.x = -1;
            }
        }
        if (Input.GetKey(KeyCode.D))
        {
            if (Input.GetKey(KeyCode.A))
                moveDirection.x += 0;
            else
                moveDirection.x = 1;
        }
        if(Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))
        {
            moveDirection.x = 0;
        }
        if(grounded && Input.GetKeyUp(KeyCode.Space))
        {
            rigidbody2D.velocity = new Vector2(0, jumpForce);
        }
        animator.SetFloat("speed", Mathf.Abs(moveDirection.x));

    }
    public void destroyPlayer()
    {
        Destroy(gameObject);
    }
     void locomotion()
    {
        Vector2 velocity = (moveDirection * Time.deltaTime * Time.timeScale * moveSpeed);
        transform.position = (Vector2)transform.position + velocity;
    }
}

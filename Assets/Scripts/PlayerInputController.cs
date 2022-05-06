using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputController : MonoBehaviour
{
    //instancia de el jugador en su clase, patron singleton
    public static PlayerInputController instance;

    public PlayerStats playerstats;
    public Animator animator;

    //variables de movimiento, ajustables a traves del inspector
    public float moveSpeed;
    public float jumpForce;

    //vector direccion para movimiento
    private Vector2 moveDirection;

    //componente rigidbody
    private Rigidbody2D rigidbody2D;

    //variable que determina si el jugador esta tocando el suelo o no
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
        //para el jugador primero se ejecuta la captura de teclas y luego los movimientos
        if(SceneController.instance.state == GameState.PLAYING)
        {
            getInputs();
            locomotion();
        }
    }

    //funcion que captura las entradas de teclado y mouse
    public void getInputs()
    {
        //claculo de la direccion de movimiento
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

    //funcion de movimiento, recive un vector direccion para desplazarse.
     void locomotion()
    {
        Vector2 velocity = (moveDirection * Time.deltaTime * Time.timeScale * moveSpeed);
        transform.position = (Vector2)transform.position + velocity;
    }
}

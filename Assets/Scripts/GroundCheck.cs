using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    public PlayerInputController playerin;
    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("colision");
        if (collision.tag == "Floor")
        {
            playerin.grounded = true;
            Debug.Log("no esta grounded");
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
       
        playerin.grounded = false;
        Debug.Log("esta grounded");
        
    }
}

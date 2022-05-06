using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    public PlayerInputController playerin;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Floor")
        {
            playerin.grounded = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
       
        playerin.grounded = false;
        
    }
}

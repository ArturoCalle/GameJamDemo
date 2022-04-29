using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraFollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector2 offset;
    private void Start()
    {
        
    }
    void Update()
    {
        if(player != null)
        {
            if((player.position.x > -10 )&& (player.position.x  < 11))
            {
                transform.position = new Vector3(player.position.x, offset.y,-10); // Camera follows the player with specified offset position            
            }
            
        }
    }
}

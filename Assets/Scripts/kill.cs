using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kill : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision){
       Debug.Log(collision);
    }
}

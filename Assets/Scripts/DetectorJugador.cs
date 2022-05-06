using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectorJugador : MonoBehaviour
{
    public Enemigo enemigo;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="Jugador")
        {
            enemigo.JugadorEnRango = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Jugador")
        {
            enemigo.JugadorEnRango = false;
        }
    }
}

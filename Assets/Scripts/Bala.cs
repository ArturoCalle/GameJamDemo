using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    public float Danio;
    public float SegundosVida;
    public float velocidad;

    private float Cronometro;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Jugador")
        {
            collision.GetComponent<PlayerStats>().Vida -= Danio;
            Destroy(gameObject);
        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Cronometro += Time.deltaTime;
        if(Cronometro >= SegundosVida)
        {
            Destroy(gameObject);
        }
        this.transform.position += transform.right * velocidad;
    }
}

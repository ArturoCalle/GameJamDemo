using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    public bool JugadorEnRango;
    public GameObject bullet;
    public Transform startPos;
    public Transform startRot;
    public float VidaEnemigo = 50.0f;
    public float puntos;

    private float disparar = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        disparar+= Time.deltaTime;
        Vector3 gunpos = PlayerInputController.instance.transform.position;
        //calculo para determinar la rotacion del asset arma
        if (gunpos.x < transform.position.x)
        {
            transform.eulerAngles = new Vector3(transform.rotation.x, 180f, transform.rotation.z);
        }
        else
        {
            transform.eulerAngles = new Vector3(transform.rotation.x, 0f, transform.rotation.z);
        }

        if(VidaEnemigo<=0)
        {
            Morir();
        }
        if(JugadorEnRango && disparar >=3)
        {
            shooting();
        }
    }
    void shooting()
    {
        disparar = 0;
        GameObject shoot = Instantiate(bullet, startPos.transform.position, startRot.transform.rotation);

    }
    void Morir()
    {
        PlayerInputController.instance.playerstats.Puntos += puntos;
        Destroy(gameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{

    public GameObject bullet;
    public Transform startPos;
    public Transform startRot;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //vector que determina la posicion del arma
        Vector3 gunpos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //calculo para determinar la rotacion del asset arma
        if(gunpos.x < transform.position.x){
            transform.eulerAngles = new Vector3(transform.rotation.x, 180f, transform.rotation.z);
        }
        else{
            transform.eulerAngles = new Vector3(transform.rotation.x, 0f, transform.rotation.z);
        }
        // verificacion del input para poder disparar en la direccion que se encuentra el arma
        if(Input.GetMouseButtonDown(0))
            shooting();
    }

    void shooting(){
        GameObject shoot = Instantiate(bullet, startPos.transform.position, startRot.transform.rotation);

    }
}

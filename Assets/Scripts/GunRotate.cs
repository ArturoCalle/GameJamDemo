using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunRotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Input.mousePosition;
        Vector3 gunposition = Camera.main.WorldToScreenPoint(transform.position);
        mousePos.x = mousePos.x - gunposition.x;
        mousePos.y = mousePos.y - gunposition.y;

        float gunangle = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg;
        if(Camera.main.ScreenToWorldPoint(Input.mousePosition).x < transform.position.x){
            transform.rotation = Quaternion.Euler(new Vector3(180f, 0f, -gunangle));
        }
        else{
            transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, gunangle));
        }

    }
}

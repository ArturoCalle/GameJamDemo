using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGunRotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 PlayerPos = PlayerInputController.instance.transform.position;
        Vector3 gunposition = Camera.main.WorldToScreenPoint(transform.position);
        PlayerPos.x = PlayerPos.x - gunposition.x;
        PlayerPos.y = PlayerPos.y - gunposition.y;

        float gunangle = Mathf.Atan2(PlayerPos.y, PlayerPos.x) * Mathf.Rad2Deg;
        if (Camera.main.ScreenToWorldPoint(Input.mousePosition).x < transform.position.x)
        {
            transform.rotation = Quaternion.Euler(new Vector3(180f, 0f, -gunangle));
        }
        else
        {
            transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, gunangle));
        }

    }

}

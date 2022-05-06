using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDControl : MonoBehaviour
{
    public PlayerStats playerStats;
    public GameObject BarraVida;
    public Text puntuacion;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        BarraVida.transform.localScale = new Vector3(playerStats.Vida / playerStats.VidaMax, 1.0f, 1.0f);
        puntuacion.text = playerStats.Puntos.ToString();
    }
}

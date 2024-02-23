using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cubo : MonoBehaviour
{
    // Start is called before the first frame update 
    public int puntos;
    public Text textoPuntos;
    void Start()
    {
        puntos = 0;
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider c)
    {

        Debug.Log("Choque tipo trigger");
        puntos++;
        textoPuntos.text = puntos.ToString();
    }
}


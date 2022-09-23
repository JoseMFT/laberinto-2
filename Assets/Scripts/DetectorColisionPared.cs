using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectorColisionPared : MonoBehaviour {
    [SerializeField]
    Material colorMuros;
    [SerializeField]
    Material choqueMuros;
    [SerializeField]

    bool colorChoque = false;
    double tiempoChoque = 0.5;
    
    private  void Update()
    {
        if (colorChoque == true)
        {
            tiempoChoque = tiempoChoque - 0.05;
            if (tiempoChoque == 0)
            {
             
                gameObject.GetComponent<MeshRenderer>().material = colorMuros;
                colorChoque = false;
            }
        
        }
        tiempoChoque = 0.5;
    }
    private void OnCollisionEnter(Collision choque) {

        if (choque.gameObject.tag == "Player") {
            Debug.Log(choque.gameObject.name);
            gameObject.GetComponent<MeshRenderer>().material = choqueMuros;

            colorChoque = true;

        }   
    }
}


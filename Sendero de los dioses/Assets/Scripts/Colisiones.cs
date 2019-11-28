using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Colisiones : MonoBehaviour
{
    public AudioSource sonido;
    public GameObject Puntuacion;
    public int  puntos=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnTriggerEnter(Collider otro){
        if(otro.tag=="Monedita"){
            Debug.Log("Esta tocandome, ESTA TOCANDOMEEEE!!");
            Destroy(otro.gameObject);
            sonido.Play();
            puntos++;
            Puntuacion.GetComponent<Text>().text=puntos.ToString();
            
        }
        
    }

}

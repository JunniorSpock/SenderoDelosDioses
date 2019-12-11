using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColisionLibro : MonoBehaviour
{
   public AudioSource sonido;
   public AudioSource sonido2;
   public GameObject textoPlanoPrefab;
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
        if(otro.tag=="Librito"){
            Debug.Log("Esta tocandome, ESTA TOCANDOMEEEE!!");
            Destroy(otro.gameObject);
            sonido.Play();
            puntos++;
            Puntuacion.GetComponent<Text>().text=puntos.ToString();

            if(textoPlanoPrefab){
                MostrarTexto();
            }
        }
        
    }

    public void MostrarTexto(){
        GameObject texto = Instantiate(textoPlanoPrefab);
        sonido2.Play();
        texto.transform.position = new Vector3(this.gameObject.transform.position.x,
        this.gameObject.transform.position.y+15, 
        this.gameObject.transform.position.z-35);
    }

}

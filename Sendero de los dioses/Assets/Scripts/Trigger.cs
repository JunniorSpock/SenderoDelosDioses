using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Trigger : MonoBehaviour
{
    // Start is called before the first frame update
    bool adentro=false,imprime=false;
    string texto;
    public GameObject contador;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     if(adentro==true&&Input.GetKeyDown(KeyCode.E)){
       Text tex=contador.GetComponent<Text>();
       texto=tex.text;
       if(int.Parse(texto)>=20){
           Debug.Log("Sacrificio hecho");  
		SceneManager.LoadScene("WinScreen");
       }else{
         imprime=true;
         adentro=false;
       }
     }   
    }
    void OnTriggerEnter(Collider other){
        adentro=true;
    }
    void OnTriggerExit(Collider other){
        adentro=false;
        imprime=false;
    }
    void OnGUI(){
        if(adentro){
         GUI.Label(new Rect(500, 500, 500, 500), "Presiona E para hacer el sacrificio.");
         
        }
        if(imprime){
          GUI.Label(new Rect(500, 500, 500, 500), "Faltan monedas para el sacrificio.");  
        }
    }
}

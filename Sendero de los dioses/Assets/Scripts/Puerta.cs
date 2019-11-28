using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puerta : MonoBehaviour
{
    public AudioSource sonido;
     public float AngleY=90.0f;
    private float targetValue=0.0f;
    private float currentValue=0.0f;
    private float easing=0.05f;
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentValue=currentValue+(targetValue-currentValue)*easing;
        target.transform.rotation = Quaternion.identity;
        target.transform.Rotate(0, currentValue,0);
        
    }
    void OnTriggerEnter(Collider other){
        Debug.Log("target Vale:"+targetValue); 
        targetValue = AngleY;
        currentValue = 0.0f;
        Debug.Log("Si entro");
        sonido.Play();
        Debug.Log("target Value:"+targetValue);

    }

    void OnTriggerExit(Collider other){
        currentValue = AngleY;
        targetValue = 0.0f;
        sonido.Play();
        Debug.Log("Salio");
    }
}

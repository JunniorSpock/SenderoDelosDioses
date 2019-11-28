using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transportar : MonoBehaviour
{
    public Transform teleportTo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other){
        Debug.Log("Si entro");
        other.transform.position=teleportTo.position;
    }
}

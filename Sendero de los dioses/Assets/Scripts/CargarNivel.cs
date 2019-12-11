using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CargarNivel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      Cursor.visible=true;
        Cursor.lockState= CursorLockMode.None;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CargarNiveles(string NombreNivel){
		SceneManager.LoadScene(NombreNivel);
	}



  public void Salir(){
    Application.Quit();
    Debug.Log("Saliste del juego");
  }
}

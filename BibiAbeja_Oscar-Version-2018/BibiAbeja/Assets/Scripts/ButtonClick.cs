﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonClick : MonoBehaviour {

   
    public string btnName="";
     string cargar = "";
    public Checador check; 


    void  OnMouseDown() {
            GetComponent<AudioSource>().Play();

        if (btnName == "btnSiguiente")
        {
            this.cargar = "recompensa";
            GetComponent<AudioSource>().Play();

            Invoke("cargarEscena", GetComponent<AudioSource>().clip.length);
        }
        else if (btnName == "btnSalir")
        {
            check.Reintentar();
            this.cargar = "eligeTema";
            GetComponent<AudioSource>().Play();
            Invoke("cargarEscena", GetComponent<AudioSource>().clip.length);
            Debug.Log("Intentando borrar el pizarrón");


        }
        else if (btnName == "btnReintentar")
        {
            check.Reintentar();
        }
        else if (btnName == "btnSalirR")
        {

            this.cargar = "reconocimiento";
             GetComponent<AudioSource>().Play();
            Invoke("cargarEscena", GetComponent<AudioSource>().clip.length);
        }
        else if (btnName == "btnAudio")
        {
            GameObject.Find("btnAudio").GetComponent<AudioSource>().Play();
        }

    }

 

    // Use this for initialization
    void Start() {
        
    }
	
	// Update is called once per frame
	void Update () {
        
	}

    public void Salir()
    {
        UnityEngine.Debug.Log("FePOPO");
       

    }




    private void cargarEscena()
    {
        SceneManager.LoadScene(cargar);

    }
}

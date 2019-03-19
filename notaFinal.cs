﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class notaFinal : MonoBehaviour {


    private int idFase;

    public Text txtNota;
    public Text txtInfoTema;

    public GameObject estrela1;
    public GameObject estrela2;
    public GameObject estrela3;

    private int notaF;
    private int acertos;
    
    void Start () {

        idFase = PlayerPrefs.GetInt("idFase");


        // iniciar estrelinhas desligadas
        estrela1.SetActive(false);
        estrela2.SetActive(false);
        estrela3.SetActive(false);


        
        notaF = PlayerPrefs.GetInt("notaFinalTemp" + idFase.ToString());
        acertos = PlayerPrefs.GetInt("acertosTemp" + idFase.ToString());
        txtNota.text = notaF.ToString();
        txtInfoTema.text = "Você acertou " + acertos.ToString() + " de 10 perguntas";  

        if (notaF == 10)
        {
            estrela1.SetActive(true);
            estrela2.SetActive(true);
            estrela3.SetActive(true);
        }
        else if(notaF >=7)
        {
            estrela1.SetActive(true);
            estrela2.SetActive(true);
            estrela3.SetActive(false);
        }
        else if (notaF >= 3)
        {
            estrela1.SetActive(true);
            estrela2.SetActive(false);
            estrela3.SetActive(false);
        }
    }

	

    public void jogarNovamente()
    {
        Application.LoadLevel("Fase" + idFase.ToString());

    }




	// Update is called once per frame
	void Update () {
		
	}
}

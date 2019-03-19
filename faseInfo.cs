﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class faseInfo : MonoBehaviour {


    public int idFase;

    public GameObject estrela1;
    public GameObject estrela2;
    public GameObject estrela3;

    private int notaFinal;



    // Use this for initialization

    void Start () {
        idFase = PlayerPrefs.GetInt("idFase");
        estrela1.SetActive(false);
        estrela2.SetActive(false);
        estrela3.SetActive(false);

        int notaFinal = PlayerPrefs.GetInt("notaFinal" + idFase.ToString());
       
        if (notaFinal == 10)
        {
            estrela1.SetActive(true);
            estrela2.SetActive(true);
            estrela3.SetActive(true);
        }
        else if (notaFinal >= 7)
        {
            estrela1.SetActive(true);
            estrela2.SetActive(true);
            estrela3.SetActive(false);
        }
        else if (notaFinal >= 3)
        {
            estrela1.SetActive(true);
            estrela2.SetActive(false);
            estrela3.SetActive(false);
        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class fasesJogo : MonoBehaviour {

    public Button btnPlay;
 //   public Text textFase;
    public GameObject infoFase;
    public Text textAcertos;

    public GameObject estrela1;
    public GameObject estrela2;
    public GameObject estrela3;

    public string[]   nomeFase;
    public int numeroQuestoes;

    private int idFase;






    void Start () {

        numeroQuestoes = 10;
        idFase = 0;
       // textFase.text = nomeFase[idFase];
        infoFase.SetActive(false);
        estrela1.SetActive(false);
        estrela2.SetActive(false);
        estrela3.SetActive(false);
        int notaFinal = PlayerPrefs.GetInt("notaFinal" + idFase.ToString());   // editar aqui depois
        int acertos = PlayerPrefs.GetInt("acertos" + idFase.ToString()); ;    // editar aqui depois


    }

    
    public void selecioneFase(int fase)
    {
        idFase = fase;
        PlayerPrefs.SetInt("idFase", idFase);
        //textFase.text = nomeFase[fase];

        int notaFinal = PlayerPrefs.GetInt("notaFinal" + idFase.ToString());   // editar aqui depois
        int acertos = PlayerPrefs.GetInt("acertos" + idFase.ToString()); ;    // editar aqui depois


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


        textAcertos.text = "Você acertou " + acertos.ToString() + " de " + numeroQuestoes.ToString() + " questões";
        infoFase.SetActive(true);
        btnPlay.interactable = true;

    }


    public void jogar()
    {
        Application.LoadLevel("Fase" + idFase.ToString());

    }



}

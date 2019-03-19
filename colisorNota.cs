using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class colisorNota : MonoBehaviour {
     private Rigidbody rb;
     public Text textoPontos;
    //  public Text textoFinal;
    private int valorNota;

    public AudioClip AudioObj;

    public void MakeAudio()
    {
        MakeSound(AudioObj);
    }
    public void MakeSound(AudioClip AudioObj)
    {
        AudioSource.PlayClipAtPoint(AudioObj, transform.position);

    }



    void Start()
    {

        //rb = GetComponent<Rigidbody2D>();
        // textoFinal.text = "";
        // textoFinal.text = textoPontos.text + pontos.ToString();

    }

    void OnTriggerEnter(Collider collider)
    {

        if (collider.gameObject.tag == "Registradora")
        {

            if (gameObject.tag == "NotaDois" || gameObject.tag == "NotaDois-1")
            {
                valorNota = 2;
            }
            if (gameObject.tag == "Nota5" || gameObject.tag == "Nota5-1")
            {
                valorNota = 5;
            }
            if (gameObject.tag == "Nota10" || gameObject.tag == "Nota10-1")
            {
                valorNota = 10;
            }
            if (gameObject.tag == "Nota20" || gameObject.tag == "Nota20-1")
            {
                valorNota = 20;
            }
            if (gameObject.tag == "Nota50" || gameObject.tag == "Nota50-1")
            {
                valorNota = 50;
            }
            if (gameObject.tag == "Nota100" || gameObject.tag == "Nota100-1")
            {
                valorNota = 100;
            }

            gameObject.SetActive(true);
            
            Destroy(gameObject);
            scoreManager.score += valorNota;
            // pontos = pontos + 1;
            //  textoPontos.text = "" + pontos.ToString();

            MakeAudio();

        }




    }

    void Update()
    {
    }
}

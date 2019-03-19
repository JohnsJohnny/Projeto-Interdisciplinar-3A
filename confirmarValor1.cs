using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class confirmarValor1 : MonoBehaviour {

    // Use this for initialization


    public void carregarCena(string nomeCena)
    {
        SceneManager.LoadScene("Acertou");
    }


    void confirmarvalor()
    {
        if(spawItens.valorItem == scoreManager.score)
        {
            carregarCena("Acertou");
        }
    }    
    

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

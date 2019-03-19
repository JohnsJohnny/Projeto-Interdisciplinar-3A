using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class spawItens : MonoBehaviour {

    public Transform[] spawPoints;
    public GameObject[] itens;
    int randomSpawnPoint;
    int randomItem;
    int totalItens=0;
    public static int valorItem;
    public static bool spawnAllowed;

 


    public void carregarCenaFaseCaixaCorreto(string Cena)
    {
        if (valorItem == scoreManager.score)
        {
            Application.LoadLevel("Acertou");
        }

        if (valorItem != scoreManager.score)
        {
            Application.LoadLevel("Errou");
        }
    }

    // Use this for initialization
    void Start()
    {
         spawnAllowed = true;
         InvokeRepeating("SpawnAItens", 0.1f, 0.9f);
         gameObject.SetActive(true);
     

    }

    void SpawnAItens()
    {
        if (totalItens ==0)
        {
            randomSpawnPoint = Random.Range(0, spawPoints.Length);
            randomItem = Random.Range(0, itens.Length);
            Instantiate(itens[randomItem], spawPoints[randomSpawnPoint].position, Quaternion.identity);
            totalItens = 1;

            if (itens[randomItem].tag == "carrinho")
            {
                valorItem = 174;

            }

            if (itens[randomItem].tag == "urso")
            {
                valorItem = 70;
            }
            if (itens[randomItem].tag == "pipa")
            {
                valorItem = 19;
            }
            if (itens[randomItem].tag == "casaco")
            {
                valorItem = 182;

            }
            if (itens[randomItem].tag == "gravata")
            {
                valorItem = 54;

            }
            if (itens[randomItem].tag == "tenis")
            {
                valorItem = 220;

            }

        }
    }


    // Update is called once per frame
    void Update()
    {
       
       
    }
}
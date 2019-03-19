using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class responder_words : MonoBehaviour {
    private int idFase;
    public Text vidaRestante;
    public Text dica;
    public Text letraA;
    public Text letraB;
    public Text letraC;
    public Text letraD;
    public Text letraE;
    public Text letraF;
    public Text letraG;
    public Text letraH;
    public Text letraI;
    public Text letraJ;
    public GameObject imgletraA;
    public GameObject imgletraB;
    public GameObject imgletraC;
    public GameObject imgletraD;
    public GameObject imgletraE;
    public GameObject imgletraF;
    public GameObject imgletraG;
    public GameObject imgletraH;
    public GameObject imgletraI;
    public GameObject imgletraJ;
    public Text letrasErradas;
    public Text infoResposta;
    public string[] dicas;      // armazenas todas as dicas
    public string[] alternativasA;  // armazenas todas as perguntas A
    public string[] alternativasB;  // armazenas todas as perguntas B
    public string[] alternativasC;  // armazenas todas as perguntas C
    public string[] alternativasD;  // armazenas todas as perguntas D    
    public string[] alternativasE;
    public string[] alternativasF;  // armazenas todas as perguntas A
    public string[] alternativasG;  // armazenas todas as perguntas B
    public string[] alternativasH;  // armazenas todas as perguntas C
    public string[] alternativasI;  // armazenas todas as perguntas D    
    public string[] alternativasJ;
    private int idDica;
    private float acertos;
    private float erros;
    private float vidas;
    private float questoes;
    private float numLetras;
    private float media;
    private int notaFinal;
	private bool errou = false;	
	public GameObject Moeda1;
	public GameObject Moeda2;
	public GameObject Moeda3;
	public GameObject Moeda4;
	public GameObject Moeda5;


void Start () {
        idFase = PlayerPrefs.GetInt("idFase");
        idDica = 0;
        vidas = 5;
		erros=0;
		acertos=0;
        questoes = dicas.Length;
	
        dica.text = dicas[idDica];
        letraA.text = alternativasA[idDica];
        letraB.text = alternativasB[idDica];
		letraC.text = alternativasC[idDica];
		letraD.text = alternativasD[idDica];
		letraE.text = alternativasE[idDica];
		letraF.text = alternativasF[idDica];
		letraG.text = alternativasG[idDica];
		letraH.text = alternativasH[idDica];
		letraI.text = alternativasI[idDica];
		letraJ.text = alternativasJ[idDica];
		
		letraA.enabled= false;
		letraB.enabled= false;
		letraC.enabled= false;
		letraD.enabled= false;
		letraE.enabled= false;
		letraF.enabled= false;
		letraG.enabled= false;
		letraH.enabled= false;
		letraI.enabled= false;
		letraJ.enabled= false;
	
        infoResposta.text = "Respondendo " + (idDica + 1).ToString() + " de " + questoes.ToString() + " perguntas!";
	
     if(letraF.text == "-"){
		imgletraF.SetActive(false);
	}
	if(letraG.text == "-"){
		imgletraG.SetActive(false);
        }
	if(letraH.text == "-"){
		imgletraH.SetActive(false);
        }
	if(letraI.text == "-"){
		imgletraI.SetActive(false);
        }
	if(letraJ.text == "-"){
		imgletraJ.SetActive(false);
        }


	if(imgletraA.activeSelf == true){
	numLetras ++;
	}
	if(imgletraB.activeSelf == true){
	numLetras ++;
	}
	if(imgletraC.activeSelf == true){
	numLetras ++;
	}
	if(imgletraD.activeSelf == true){
	numLetras ++;
	}
	if(imgletraE.activeSelf == true){
	numLetras ++;
	}
	if(imgletraF.activeSelf == true){
	numLetras ++;
	}
	if(imgletraG.activeSelf == true){
	numLetras ++;
	}
	if(imgletraH.activeSelf == true){
	numLetras ++;
	}
	if(imgletraI.activeSelf == true){
	numLetras ++;
	}	
	if(imgletraJ.activeSelf == true){
	numLetras ++;
	}	
	
    }

void Update(){

	if(letraF.text == "-"){
		imgletraF.SetActive(false);
	}
	if(letraG.text == "-"){
		imgletraG.SetActive(false);
        }
	if(letraH.text == "-"){
		imgletraH.SetActive(false);
        }
	if(letraI.text == "-"){
		imgletraI.SetActive(false);
        }
	if(letraJ.text == "-"){
		imgletraJ.SetActive(false);
        }



	if(erros==5) {
	    media = 10 * (acertos / questoes);   // valor da média   
            notaFinal = Mathf.RoundToInt(media); // arredonda o valor da média

            // ATUALIZA RECORD **
          //  if (notaFinal > PlayerPrefs.GetInt("notaFinal" + idFase.ToString()))
         //   {
          //      PlayerPrefs.SetInt("notaFinal" + idFase.ToString(), notaFinal);
          //      PlayerPrefs.SetInt("acertos" + idFase.ToString(),(int) acertos);
           // }

         //   PlayerPrefs.SetInt("notaFinalTemp" + idFase.ToString(), notaFinal);
         //   PlayerPrefs.SetInt("acertosTemp" + idFase.ToString(), (int)acertos);

            Application.LoadLevel("ErrouLetras"); // carregar tela nota final
		}



	if(numLetras.Equals(acertos)){
		
   	idDica += 1;
	numLetras = 0;


    if (idDica > (questoes - 1))
     {
     Application.LoadLevel("AcertouLetras");
     }




    if (idDica <= (questoes - 1))
        {
     imgletraF.SetActive(true);
		imgletraG.SetActive(true);
        imgletraH.SetActive(true);
        imgletraI.SetActive(true);
        imgletraJ.SetActive(true);   	
	dica.text = dicas[idDica];
    letraA.text = alternativasA[idDica];
    letraB.text = alternativasB[idDica];
	letraC.text = alternativasC[idDica];
	letraD.text = alternativasD[idDica];
	letraE.text = alternativasE[idDica];
	letraF.text = alternativasF[idDica];
	letraG.text = alternativasG[idDica];
	letraH.text = alternativasH[idDica];
	letraI.text = alternativasI[idDica];
	letraJ.text = alternativasJ[idDica];
	if(letraF.text == "-"){
		imgletraF.SetActive(false);
	}
	if(letraG.text == "-"){
		imgletraG.SetActive(false);
        }
	if(letraH.text == "-"){
		imgletraH.SetActive(false);
        }
	if(letraI.text == "-"){
		imgletraI.SetActive(false);
        }
	if(letraJ.text == "-"){
		imgletraJ.SetActive(false);
        }

	letraA.enabled= false;
	letraB.enabled= false;
	letraC.enabled= false;
	letraD.enabled= false;
	letraE.enabled= false;
	letraF.enabled= false;
	letraG.enabled= false;
	letraH.enabled= false;
	letraI.enabled= false;
	letraJ.enabled= false;
            infoResposta.text = "Respondendo " + (idDica + 1).ToString() + " de " + questoes.ToString() + " perguntas!";

	if(imgletraA.activeSelf == true){
	numLetras ++;
	}
	if(imgletraB.activeSelf == true){
	numLetras ++;
	}
	if(imgletraC.activeSelf == true){
	numLetras ++;
	}
	if(imgletraD.activeSelf == true){
	numLetras ++;
	}
	if(imgletraE.activeSelf == true){
	numLetras ++;
	}
	if(imgletraF.activeSelf == true){
	numLetras ++;
	}
	if(imgletraG.activeSelf == true){
	numLetras ++;
	}
	if(imgletraH.activeSelf == true){
	numLetras ++;
	}
	if(imgletraI.activeSelf == true){
	numLetras ++;
	}	
	if(imgletraJ.activeSelf == true){
	numLetras ++;
	}
        
        
    }
        erros = 0;
        acertos = 0;
        Moeda1.SetActive(false);
        Moeda2.SetActive(false);
        Moeda3.SetActive(false);
        Moeda4.SetActive(false);
        Moeda5.SetActive(false);

}
}

public void resposta(string Alternativa){								
			if(Alternativa == letraA.text){
				if(letraA.enabled == false){
					acertos ++;
					letraA.enabled= true;
				}
				
			}

			if(Alternativa == letraB.text){
				if(letraB.enabled == false){
				acertos ++;
				letraB.enabled= true;
				}
			}if(Alternativa == letraC.text){
				if(letraC.enabled == false){
				acertos ++;
				letraC.enabled= true;
				}
			}if(Alternativa == letraD.text){
				if(letraD.enabled == false){
				acertos ++;
				letraD.enabled= true;
				}
			}if(Alternativa == letraE.text){
				if(letraE.enabled == false){
				acertos ++;
				letraE.enabled= true;
			}
			}if(Alternativa == letraF.text){
				if(letraF.enabled == false){
				acertos ++;
				letraF.enabled= true;
			}
			}if(Alternativa == letraG.text){
				if(letraG.enabled == false){
				acertos ++;
				letraG.enabled= true;
			}
			}if(Alternativa == letraH.text){
				if(letraH.enabled == false){
				acertos ++;
				letraH.enabled= true;
			}
			}if(Alternativa == letraI.text){
				if(letraI.enabled == false){
				acertos ++;
				letraI.enabled= true;
			}
			}if(Alternativa == letraJ.text){
				if(letraJ.enabled == false){
				acertos ++;
				letraJ.enabled= true;
			}
			}

			if(acertos==1){
				Moeda1.SetActive(true);
			}if(acertos==2){
				Moeda2.SetActive(true);
			}if(acertos==3){
				Moeda3.SetActive(true);
			}if(acertos==4){
				Moeda4.SetActive(true);
			}if(acertos==5){
				Moeda5.SetActive(true);
            }



			if(Alternativa != letraA.text){
			
			if(Alternativa != letraB.text){
				
			if(Alternativa != letraC.text){
				
			if(Alternativa != letraD.text){
				
			if(Alternativa != letraE.text){
				
			if(Alternativa != letraF.text){
				
			if(Alternativa != letraG.text){
				
			if(Alternativa != letraH.text){
				
			if(Alternativa != letraI.text){
				
			if(Alternativa != letraJ.text){
				errou = true;
           

			}
			}}}}}}}}}

        if (errou == true)
        {

            vidas--; // aqui conta os erros
            vidaRestante.text = vidas.ToString();
            letrasErradas.text = letrasErradas.text + "   " + Alternativa.ToString();
            erros++;
            errou = false;

        }



}
}
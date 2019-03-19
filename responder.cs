using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class responder : MonoBehaviour {

    private int idFase;

    public Text pergunta;
    public Text respostaA;
    public Text respostaB;
    public Text respostaC;
    public Text respostaD;
    public Text infoResposta;
    

    public string[] perguntas;      // armazenas todas as perguntas
    public string[] alternarivasA;  // armazenas doas as perguntas A
    public string[] alternarivasB;  // armazenas doas as perguntas B
    public string[] alternarivasC;  // armazenas doas as perguntas C
    public string[] alternarivasD;  // armazenas doas as perguntas D    
    public string[] corretas;       // armazenas todas as respostas
    public string[] imagens;

    private int idPergunta;

    private float acertos;
    private string erros;
    private float questoes;
    private float media;
    private int notaFinal;

    // Use this for initialization
    void Start () {
        idFase = PlayerPrefs.GetInt("idFase");
        idPergunta = 0;
        questoes = perguntas.Length;

        pergunta.text = perguntas[idPergunta];
        respostaA.text = alternarivasA[idPergunta];
        respostaB.text = alternarivasB[idPergunta];
        respostaC.text = alternarivasC[idPergunta];
        respostaD.text = alternarivasD[idPergunta];

        infoResposta.text = "Respondendo " + (idPergunta + 1).ToString() + " de " + questoes.ToString() + " perguntas!";


    }
	

    public void resposta(string Alternativa)
    {
        if(Alternativa == "A")
        {
            // executa o comando para a resposta A
            if (alternarivasA[idPergunta] == corretas[idPergunta])
            {
                acertos += 1;
            }
            else if (alternarivasA[idPergunta] != corretas[idPergunta]) {
                erros = erros + (idPergunta+1).ToString() + "  ";
            }
        }

        else if (Alternativa == "B")
        {
            // executa o comando para a resposta B
            if (alternarivasB[idPergunta] == corretas[idPergunta])
            {
                acertos += 1;
            }
            else if (alternarivasB[idPergunta] != corretas[idPergunta]) {
                erros = erros + (idPergunta + 1).ToString() + "  ";
            }
        }

        else if (Alternativa == "C")
        {
            // executa o comando para a resposta C
            if (alternarivasC[idPergunta] == corretas[idPergunta])
            {
                acertos += 1;
            }
            else if (alternarivasC[idPergunta] != corretas[idPergunta]) {
                erros = erros + (idPergunta + 1).ToString() + "  ";
            }
        }

        else if (Alternativa == "D")
        {
            // executa o comando para a resposta D
            if (alternarivasD[idPergunta] == corretas[idPergunta])
            {
                acertos += 1;
            }
            else if (alternarivasD[idPergunta] != corretas[idPergunta]) {
                erros = erros + (idPergunta + 1).ToString() + "  ";
            }
        }

       
        proximaPergunta(); // atualiza para próxima pergunta
    }

    void proximaPergunta()
    {
        // atualiza quadro de perguntas e repostas
        idPergunta += 1;

        if (idPergunta <= (questoes - 1))
        {

            pergunta.text = perguntas[idPergunta];
            respostaA.text = alternarivasA[idPergunta];
            respostaB.text = alternarivasB[idPergunta];
            respostaC.text = alternarivasC[idPergunta];
            respostaD.text = alternarivasD[idPergunta];

            infoResposta.text = "Respondendo " + (idPergunta + 1).ToString() + " de " + questoes.ToString() + " perguntas!";
        }
        else
        {

            // o que fazer quando terminar as perguntas
            
            media = 10 * (acertos / questoes);   // valor da média   
            notaFinal = Mathf.RoundToInt(media); // arredonda o valor da média

            // ATUALIZA RECORD **
            if (notaFinal > PlayerPrefs.GetInt("notaFinal" + idFase.ToString()))
            {
                PlayerPrefs.SetInt("notaFinal" + idFase.ToString(), notaFinal);
                PlayerPrefs.SetInt("acertos" + idFase.ToString(),(int) acertos);
            }

            PlayerPrefs.SetInt("notaFinalTemp" + idFase.ToString(), notaFinal);
            PlayerPrefs.SetInt("acertosTemp" + idFase.ToString(), (int)acertos);

            PlayerPrefs.SetString("erradas", erros); // salva erradas para aparecer no resultado final


            Application.LoadLevel("NotaFinal"); // carregar tela nota final



        }
    }
}

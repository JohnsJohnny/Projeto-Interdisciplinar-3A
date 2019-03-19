using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mostrarErradas : MonoBehaviour {

    public Text questoesErradas;

    private string qErradas;



    // Use this for initialization
    void Start () {
		
        qErradas = PlayerPrefs.GetString("erradas");
        print(qErradas);
        questoesErradas.text = qErradas.ToString();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

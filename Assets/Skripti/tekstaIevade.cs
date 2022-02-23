using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tekstaIevade: MonoBehaviour {
	//Uzglabās tekstu, kurš paņemts no input laika
	public string teksts;
	public string vecums;
	//Lauks no, kura es tekstu paņemšu
	public GameObject ievadesLauks;
	public GameObject ievadesLauks2;
	//Teksta objekts, kur attēlot mainīgo teksta saturu
	public GameObject TekstaAttelosanasLauks;
	public GameObject TekstaAttelosanasLauks2;

	public void darbibasArTekstu(){
		teksts = ievadesLauks.GetComponent<Text> ().text;
		TekstaAttelosanasLauks.GetComponent<Text> ().text = "Supervaronis " + teksts+" ir "+vecums+" gadus vecs!";
	}
		
}


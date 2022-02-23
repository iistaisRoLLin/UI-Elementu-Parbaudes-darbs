using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ParaditAttelu : MonoBehaviour {
	public GameObject cepure;
	public GameObject pufaika;
	public GameObject cimdi;
	public GameObject bikses;
	public Sprite[] atteluMasivs; 
	public GameObject attelaTuretajs;
	public GameObject attelaTuretajs2;
	public GameObject slaideris;
	public GameObject slaideris2;
	public void cepureAttelosana(bool vertiba){
		cepure.SetActive(vertiba);
	}
	public void pufaikaAttelosana(bool vertiba){
		pufaika.SetActive(vertiba);
	}
	public void cimdiAttelosana(bool vertiba){
		cimdi.SetActive(vertiba);
	}
	public void biksesAttelosana(bool vertiba){
		bikses.SetActive(vertiba);
	}
	public void izkritosais(int skaitlis){
		if (skaitlis == 0){
			attelaTuretajs.GetComponent<Image>().sprite = atteluMasivs [0];

		}else if(skaitlis == 1){
			attelaTuretajs.GetComponent<Image>().sprite = atteluMasivs [1];
		}
}
	public void mainitIzmeru(){
		float izmers = slaideris.GetComponent<Slider> ().value;
		attelaTuretajs.transform.localScale = new Vector2 (1f*izmers,0);
	}
	public void mainitIzmeru2(){
		float izmers2 = slaideris2.GetComponent<Slider> ().value;
		attelaTuretajs2.transform.localScale = new Vector2 (0, 1f*izmers2);
	}
}

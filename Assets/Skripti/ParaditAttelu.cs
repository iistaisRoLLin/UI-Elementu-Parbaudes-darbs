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
}

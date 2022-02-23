using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class objektuParvietosana : MonoBehaviour, IPointerDownHandler, IDragHandler, IBeginDragHandler, IEndDragHandler{
	private RectTransform transformacijasLogs;
	public Canvas kanva;
	private void Awake(){
		transformacijasLogs = GetComponent<RectTransform> ();
	}
	public void OnPointerDown(PointerEventData notikums){
		Debug.Log ("Kreisais kliksis uz parvietojuma objekta!");
	}

	public void OnDrag(PointerEventData notikums){
		Debug.Log ("Objekts tiek parvietots");
		transformacijasLogs.anchoredPosition += notikums.delta / kanva.scaleFactor;
	}
	public void OnBeginDrag(PointerEventData notikums){
		Debug.Log ("Uzsākta objekta pārvietošanās");
	}
	public void OnEndDrag(PointerEventData notikums){
		Debug.Log ("Pabeigta objekta parvietosanas!");
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Jāimporte, lai lietotu visus I interfeisus
using UnityEngine.EventSystems;

public class DragDropSkripts : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IDragHandler, IEndDragHandler {
	//Velkamajam objektam piestiprinātā komponente
	private CanvasGroup kanvasGrupa;
	//Priekš pārvietojamā opbjekta atrašanās vietas uzglabāšanas
	private RectTransform velkObjRectTransf;
	//Norāde uz objektu skriptu
	public Objekti objektuSkripts;

	// Use this for initialization
	void Start () {
		//Piekļūst objekta piestiprinātajai CanvasGroup komponentei
		kanvasGrupa = GetComponent<CanvasGroup>();
		//Piekļūst objekta RectTransform komponentei
		velkObjRectTransf = GetComponent<RectTransform>();
	}

	public void OnPointerDown(PointerEventData notikums){
		Debug.Log ("Uzklikšināts uz velkama objekta!");
	}

	public void OnBeginDrag(PointerEventData notikums){
		Debug.Log ("Uzsākta vilkšana!");
		//Velkot objektu tas paliek caurspīdīgs
		kanvasGrupa.alpha = 0.6f;
		//Lai objektam velkot iet cauri raycast stari
		kanvasGrupa.blocksRaycasts = false;
	}
		
	public void OnDrag(PointerEventData notikums){
		Debug.Log ("Notiek vilkšana!");
		//Maina objekta x, y koordinātas
		velkObjRectTransf.anchoredPosition += notikums.delta / objektuSkripts.kanva.scaleFactor;
	}

	public void OnEndDrag(PointerEventData notikums){
		Debug.Log ("Beigta objekta vilkšana!");
	//Rīt turpināsim
	}
}

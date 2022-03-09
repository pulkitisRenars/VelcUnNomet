using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objekti : MonoBehaviour {
	//Uzglabā ainā esošo kanvu
	public Canvas kanva;

	public GameObject atkritumuMasina;
	public GameObject atraPalidziba;
	public GameObject autobuss;

	[HideInInspector]
	public Vector2 atkrKord;
	[HideInInspector]
	public Vector2 autoKord;
	[HideInInspector]
	public Vector2 atraKord;


	public AudioSource skanasAvots;

	public AudioClip[] skanasKoAtsk;

	public bool vaiIstajaVieta = false; 

	public GameObject pedejaisVilktais = null;



	// Use this for initialization
	void Start () {
		atkrKord = atkritumuMasina.GetComponent<RectTransform> ().localPosition;
		autoKord = autobuss.GetComponent<RectTransform> ().localPosition;
		atraKord = atraPalidziba.GetComponent<RectTransform> ().localPosition;
	}

}

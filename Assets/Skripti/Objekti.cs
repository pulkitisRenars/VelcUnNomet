using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objekti : MonoBehaviour {
	//Uzglabā ainā esošo kanvu
	public Canvas kanva;

	public GameObject atkritumuMasina;
	public GameObject atraPalidziba;
	public GameObject autobuss;


	public Vector2 atkrKord;
	[HideInInspector]
	public Vector2 autoKord;
	[HideInInspector]
	public Vector2 atraKord;
	[HideInInspector]

	public AudioSource skanasAvots;

	public AudioClip[] skanasKoAtsk;

	public bool vaiIstajaVieta = false; 

	public GameObject pedejaisVilktais = null;



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

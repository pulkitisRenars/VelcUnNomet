using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class NomesanasVieta : MonoBehaviour, IDropHandler {

	private float vietasZrot, velkObjZrot, rotStarpiba, xIzmStarpiba, yIzmStarpiba;
	private Vector2 vietasIzm, velkObjIzm;
	public Objekti objektuSkripts;

	public void OnDrop(PointerEventData notikums){
		if (notikums.pointerDrag != null) {
			if (notikums.pointerDrag.tag.Equals(tag)) {
				vietasZrot = notikums.pointerDrag.GetComponent<RectTransform> ().eulerAngles.z;
				velkObjZrot = GetComponent<RectTransform> ().eulerAngles.z;
				rotStarpiba = Mathf.Abs (vietasZrot - velkObjZrot);
				vietasIzm = notikums.pointerDrag.GetComponent<RectTransform> ().localScale;
				velkObjIzm = GetComponent<RectTransform> ().localScale;
				xIzmStarpiba = Mathf.Abs (vietasIzm.x - velkObjIzm.x);
				yIzmStarpiba = Mathf.Abs (vietasIzm.y - velkObjIzm.y);

				Debug.Log ("Pareizi");
				if ((rotStarpiba <= 6 || (rotStarpiba >= 354 && rotStarpiba <= 360 && xIzmStarpiba <= 0.1 && yIzmStarpiba < 0.1))) {
					objektuSkripts.vaiIstajaVieta = true;
					notikums.pointerDrag.GetComponent<RectTransform> ().anchoredPosition = GetComponent<RectTransform> ().localPosition;
					notikums.pointerDrag.GetComponent<RectTransform> ().localRotation = GetComponent<RectTransform> ().localRotation;
					notikums.pointerDrag.GetComponent<RectTransform> ().localScale = GetComponent<RectTransform> ().localScale;

					switch (notikums.pointerDrag.tag) {
					case "Atkritumi":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanasKoAtsk [1]);
						break;
					case "Slimnica":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanasKoAtsk [2]);
						break;
					case "Skola":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanasKoAtsk [3]);
						break;
					default:
						Debug.Log ("Nederigs tag!!!!");
						break;
					}
				}
				}else{
				Debug.Log ("Nepareizi");
					objektuSkripts.vaiIstajaVieta = false;
					objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanasKoAtsk [0]);

					switch (notikums.pointerDrag.tag) {
					case "Atkritumi":
						objektuSkripts.atkritumuMasina.GetComponent<RectTransform> ().localPosition = objektuSkripts.atkrKord;
						break;
					case "Slimnica":
						objektuSkripts.autobuss.GetComponent<RectTransform> ().localPosition = objektuSkripts.autoKord;
						break;
					case "Skola":
						objektuSkripts.atraPalidziba.GetComponent<RectTransform> ().localPosition = objektuSkripts.atraKord;
						break;
					default:
						Debug.Log ("Nederigs tag!!!!");
						break;
					}
					}
			}
		}
	
	}



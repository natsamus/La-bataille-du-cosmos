using UnityEngine;
using System.Collections;

public class parametre : MonoBehaviour {
	protected KeyCode avant;
	protected KeyCode arriere;
	protected KeyCode gauche;
	protected KeyCode droite;
	protected KeyCode saut;
	protected KeyCode attaque;
	protected KeyCode special1;
	protected KeyCode special2;
	protected KeyCode special3;
	protected KeyCode discussion;
	// Use this for initialization
	void Start () {
		avant = KeyCode.UpArrow;
		arriere = KeyCode.DownArrow;
		gauche = KeyCode.LeftArrow;
		droite = KeyCode.RightArrow;
		saut = KeyCode.Space;
		attaque = KeyCode.Mouse0;
		special1 = KeyCode.Keypad1;
		special2 = KeyCode.Keypad2;
		special3 = KeyCode.Keypad3;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

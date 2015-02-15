using UnityEngine;
using System.Collections;

public class personnage : parametre {
	protected string name;
	protected int vie;
	protected int magie;
	protected int degat_phi;
	protected int degat_mag;
	protected int defense_phi;
	protected int defense_mag;
	protected int niveau;
	protected int experience;
	protected bool jedi;
	protected int capacite_de_port;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (saut)) {
						// animation de saut
				} 
		else if (Input.GetKey (avant)) {
			// animation avant
				}
		else if (Input.GetKey (arriere)) {
			// animation arriere
		}
		else if (Input.GetKey (gauche)) {
			// animation gauche
		}
		else if (Input.GetKey (droite)) {
			// animation gauche
		}
		else if (Input.GetKey (attaque)) {
			// animation attaque
		}
	}
}

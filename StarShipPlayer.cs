using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarShipPlayer : MonoBehaviour {


	float  speed = 10;
	int energia;
	bool escudoAtivado;
	string nomeNave;

	Animator anim;



	// Use this for initialization
	void Start () {
		energia = 100;
		escudoAtivado = false;
		nomeNave  = "ncc Hermes";

		anim = GetComponent<Animator> ();

	}
	
	// Update is called once per frame
	void Update () {

		//obtem a direção da nave via copntrole 
		float x = Input.GetAxisRaw ("Horizontal");
		float y = Input.GetAxisRaw ("Vertical");



		if (x > 0) {
			anim.SetBool ("idleToRight", true);
		} else if (x < 0) {
			anim.SetBool ("idleToLeft", true);
		} else {
			anim.SetBool ("idleToRight", false);
			anim.SetBool ("idleToLeft", false);
		}




		//obtem posicao atual do gameobject
		Vector2 posicaoAtual = transform.position;
		Vector2 direcao = new Vector2 (x, y);

		// atualiza posição atual da nave
		posicaoAtual = posicaoAtual + direcao * speed * Time.deltaTime;

		transform.position = posicaoAtual;








	}
}

using UnityEngine;
using System.Collections;

public class Pontuacao : MonoBehaviour {

	public GUIText pontuacao;
	private int pontos;

	// Use this for initialization
	void Start(){
		pontos = 0;
		OrganizarPontuacao();
	}
	
	void Update(){
		
		
	}
	
	void OnTriggerEnter (Collider other){
		if (other.gameObject.tag == "Item") {
						other.gameObject.SetActive(false);
						pontos = pontos + 10;
						OrganizarPontuacao ();
				}
	}
	
	void OrganizarPontuacao(){
		pontuacao.text = "Pontos : " + pontos;
	}
}

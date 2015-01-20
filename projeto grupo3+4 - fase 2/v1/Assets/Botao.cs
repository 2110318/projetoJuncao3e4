using UnityEngine;
using System.Collections;



public class Botao : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	

	}

	void OnGUI(){
		GUI.Window (0, new Rect ((Screen.width/2)-350, (Screen.height/2)-200, 600, 300),option,"");
		GUI.TextArea (new Rect ((Screen.width/2)-350, (Screen.height/2)-200, 600, 300), "O jogo consiste em avaliar facores ambientais favoraveis prejudiciais ao planeta de Terra.\n Este jogo inicia-se com personagem rodeada de diversos fatores que tera de recolher para salvar o planeta.\n Como todos os jogos temos regras e esta nao salva a exceçao.As regras deste jogo:\n    * A pernsonagem (homem) ao recolher o elemento agua, a arvore, ecoponto, animal recebera um bonus de 10 pontos. \n    * a personagem (homem) ao receber o elemento fogo, poluiçao recebera uma penalizaçao de -5 pontos. \n O jogo termina quando todos os factores positivos forem recolhidos.");
						
			
	}

	void option(int id){
		 
		if (GUI.Button (new Rect (330, 200, 80, 50),"Sair")) {
			Application.Quit();		
		}
		if (GUI.Button (new Rect (220, 200, 80, 50),"Jogar")) {
			Application.LoadLevel("selecionar_player");		
		}
		
	} 
}

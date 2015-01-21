using UnityEngine;
using System.Collections;

public class Botao : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.Escape))
		{
			Application.Quit();
		}
		
	}
	
	void OnGUI(){
		GUI.Window (0, new Rect ((Screen.width/2)-300, (Screen.height/2)-200, 700, 400),option,"");
		GUI.TextArea (new Rect ((Screen.width/2)-300, (Screen.height/2)-200, 700, 400), "O jogo consiste em avaliar " +
		              "fatores ambientais favoraveis prejudiciais ao planeta Terra.\n Este jogo inicia-se com a personagem rodeada " +
		              "de diversos fatores que tera de recolher para salvar o planeta.\n Como todos os jogos temos regras e esta nao " +
		              "salva a exceçao.As regras deste jogo:\n * A pernsonagem (homem) ao recolher o elemento agua, a arvore " +
		              "e ecoponto recebera um bonus de 10 pontos. \n * a personagem (homem) ao receber o elemento fogo e " +
		              "poluiçao recebera uma penalizaçaode -5 pontos. \n O jogo termina quando todos os fatores positivos forem recolhidos.\n" +
		              "O jogador pode escolher a opçao SinglePlayer onde so tera um cenario, ou podera, querer jogar com outro jogador (MultiPlayer) onde devera ter atençao" +
		              " as seguintes teclas :\n \n" +
		              "               Jogador 1: " +      "                                                   Jogador 2: \n" +              
		              "                        - w andar para frente " +   "                                       - i andar para frente\n" +
		              "                        - s andar para tras " +          "                                          - k andar para tras\n" +
		              "                        - d andar para direita " +       "                                       - l andar para direita\n" +      
		              "                        - a andar para a esquerda " +    "                                - j andar para a esquerda\n ");
		
		
		
		
	}
	
	void option(int id){
		
		if (GUI.Button (new Rect (350, 300, 80, 50),"Sair")) {
			Application.Quit();		
		}
		if (GUI.Button (new Rect (250, 300, 80, 50),"Jogar")) {
			Application.LoadLevel("Selecionar_Player");		
		}
		
	}
}

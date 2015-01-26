using UnityEngine;
using System.Collections;
using System;
using System.IO;

public class PickUpItems : MonoBehaviour
{
		public Gestao_Players gestaoPlayers;
		public itemTextContadorScript txtGotas;
		public itemTextContadorScript txtContentores;
		public itemTextContadorScript txtArvores;
		public tempoScript tempoScript;
		public VidasScript vidas;
		public int numeroItemsBons;
		public AudioClip somItemBom;
		public AudioClip somItemMau;
		public AudioClip somAgua;
		public AudioClip somMoeda;
		public int numMoedas;
		public GUIText pontuacao;
		public GUIText txtMoedas;
		public int contagemMoedas;
		private int numero;
		private float deltaTime;
		private static int pontos;
		private static int nivel;
		private int contarBom = 0;
		private int contarMau = 0;
		private string itemMau = "";
		private string itemBom = "";
		private string tempo = "";
		private string vida = "";
	

	
		private int contagem;
		private string path = @"Assets\Data.csv";
		private string pathMulti = @"Assets\DataMultiplayer.csv";
		public GUIText gameOverText;
		private float time;
		private string appendText;
		private string createText;
		private string contarFinalBons;
		private string contarFinalMaus;
		public static DateTime date = DateTime.Now;
	
		//public static int idade;


		// Use this for initialization
		void Start ()
		{

				OrganizarPontuacao ();

		}

		void Update ()
		{


		}



		private void OnTriggerEnter (Collider other)
		{

				if (other.gameObject.tag == "ItemComTempo") {
						if (other.GetComponentInChildren<txtTempo_Script> () != null) {
								int tempo = other.GetComponentInChildren<txtTempo_Script> ().tempoContagem;
								if (tempo != 0) {
										contagem++;
										Debug.Log (contagem);
								}
						}
				}


				if (other.gameObject.tag == "ItemBom") {

						pontos = pontos + 10;
						numero = numero + 1;
						OrganizarPontuacao ();
						NumeroSoma ();

						atualizarContagens (other.name);

						other.gameObject.SetActive (false);
						AudioSource.PlayClipAtPoint (somItemBom, this.transform.position);

				} else if (other.gameObject.tag == "ItemMau") {
						other.gameObject.SetActive (false);
						pontos = pontos - 5;
						OrganizarPontuacao ();
						AudioSource.PlayClipAtPoint (somItemMau, this.transform.position);
				} else if (other.gameObject.tag.Equals ("Agua")) {
						AudioSource.PlayClipAtPoint (somAgua, new Vector3 (120, 10, 130));
						tempoScript.reiniciarNivel ();
				} else if (other.gameObject.tag.Equals ("ItemMoedas")) {
						other.transform.GetChild (0).gameObject.SetActive (true);
						other.GetComponent<ItemRotator> ().enabled = false;
						other.GetComponent<MeshRenderer> ().enabled = false;
				} else if (other.gameObject.name.StartsWith ("Moeda")) {
						contagemMoedas++;
						txtMoedas.text = "" + contagemMoedas;
						Debug.Log ("colidiu: " + contagemMoedas);
						other.gameObject.SetActive (false);
						AudioSource.PlayClipAtPoint (somMoeda, transform.position);
				}
				guardarFicheiro (other);
		}

		private void atualizarContagens (string nomeObjeto)
		{
				switch (nomeObjeto) {
				case "ItemBom_gota":
						txtGotas.incrementarContagem ();
						break;
				case "ItemBom_contentor":
						txtContentores.incrementarContagem ();
						break;
				case "ItemBom_arvore":
						txtArvores.incrementarContagem ();
						break;

				}

		}

		void OrganizarPontuacao ()
		{
				pontuacao.text = "Pontos : " + pontos;
		}

		void NumeroSoma ()
		{
				if (numero == numeroItemsBons) {
						nivel++;

						if (nivel > 5)
								Application.LoadLevel ("Fim_Jogo");
						else
								Application.LoadLevel ("Nivel_" + nivel);

				}
		}
	

		public void reiniciar ()
		{
				pontos = 0;
				nivel = 0;
				vidas.reiniciar ();
		}

		private void guardarFicheiro (Collider other)
		{
				time = Mathf.Round (Time.timeSinceLevelLoad); //irá contar o tempo desde o inicio do jogo


				if (other.gameObject.tag == "ItemBom" || other.gameObject.tag == "ItemMau") { //a tag do objeto for "ItemBom" ou "ItemMau"
						//  other.gameObject.SetActive(false);//o objeto que o player apanha desaparece
			
						if (other.gameObject.tag == "ItemBom") { //se a tag do objeto apanhado for "ItemBom"
								contarBom++; //incrementa mais um
								//contarFinalBons = contarBom.ToString();
				
						} else if (other.gameObject.tag == "ItemMau") {//se a tag do objeto apanhado for "ItemMau"
								contarMau++;//incrementa mais um
								//contarFinalMaus = contarMau.ToString();
				
						}
						itemMau = contarMau.ToString (); //constroi a string a dando-lhe o valor "ItemMau" concatenado com o numero de contarMau 
						itemBom = contarBom.ToString ();//constroi a string b dando-lhe o valor "ItemMau" concatenado com o numero de contarBom 
						tempo = time.ToString ();//constroi a string c dando-lhe o valor "Tempo" concatenado com o tempo que demorou a apanhar o item 
						vida = vidas.NumVidas.ToString ();//constrói a string d dando-lhe o valor "Vida" concatenado com o número de vidas restante
		
				}

				if (PlayerPrefs.GetString ("Player").Equals ("Single")) {
						if (contarBom == numeroItemsBons && nivel <= 5) {

								if (File.Exists (path)) { //se o ficheiro existir
										appendText = date.ToString () + ", " + Gestao_Players.perfil1.idade.ToString () + ", " + Gestao_Players.perfil1.sexo.ToString () + ", " + Gestao_Players.perfil1.anoEscolar + ", " + itemMau + ", " + itemBom + ", " + tempo + ", " + vida + ", " + (nivel - 1) + ", " + pontos + ", " + contagem + ", " + "Nao" + Environment.NewLine;
										File.AppendAllText (path, appendText);
				
				
								}
								if (!File.Exists (path)) {
										createText = date.ToString () + ", " + Gestao_Players.perfil1.idade.ToString () + ", " + Gestao_Players.perfil1.sexo.ToString () + ", " + Gestao_Players.perfil1.anoEscolar + ", " + itemMau + ", " + itemBom + ", " + tempo + ", " + vida + ", " + (nivel - 1) + ", " + pontos + ", " + contagem + ", " + "Nao" + Environment.NewLine;
										File.WriteAllText (path, createText);
			
								}
		
						}
						if (contarBom == numeroItemsBons && nivel == 6) {
			
								appendText = date.ToString () + ", " + Gestao_Players.perfil1.idade.ToString () + ", " + Gestao_Players.perfil1.sexo.ToString () + ", " + Gestao_Players.perfil1.anoEscolar + ", " + itemMau + ", " + itemBom + ", " + tempo + ", " + vida + ", " + (nivel - 1) + ", " + pontos + ", " + contagem + ", " + "Sim" + Environment.NewLine;
								File.AppendAllText (path, appendText);
						}

			//zona multiplayer
				} else if (PlayerPrefs.GetString ("Player").Equals ("Multi")) {

						if (contarBom == numeroItemsBons && nivel <= 5) {
				
				if (File.Exists (pathMulti)) { //se o ficheiro existir
					appendText = "Grupo" + date.ToString () +Gestao_Players.perfil1.jogador+ ", " + Gestao_Players.perfil1.idade.ToString () + ", " + Gestao_Players.perfil1.sexo.ToString () + ", " + Gestao_Players.perfil1.anoEscolar + ", " + itemMau + ", " + itemBom + ", " + tempo + ", " + vida + ", " + (nivel - 1) + ", " + pontos + ", " + contagem + ", " + "Nao" + Environment.NewLine;
								File.AppendAllText (pathMulti, appendText);
					appendText = "Grupo" + date.ToString () +Gestao_Players.perfil2.jogador+ ", " + Gestao_Players.perfil2.idade.ToString () + ", " + Gestao_Players.perfil2.sexo.ToString () + ", " + Gestao_Players.perfil2.anoEscolar + ", " + itemMau + ", " + itemBom + ", " + tempo + ", " + vida + ", " + (nivel - 1) + ", " + pontos + ", " + contagem + ", " + "Nao" + Environment.NewLine;
					File.AppendAllText (pathMulti, appendText);
			
					
								}
				if (!File.Exists (pathMulti)) {
					createText ="Grupo" + date.ToString () +Gestao_Players.perfil1.jogador+ ", " + Gestao_Players.perfil1.idade.ToString () + ", " + Gestao_Players.perfil1.sexo.ToString () + ", " + Gestao_Players.perfil1.anoEscolar + ", " + itemMau + ", " + itemBom + ", " + tempo + ", " + vida + ", " + (nivel - 1) + ", " + pontos + ", " + contagem + ", " + "Nao" + Environment.NewLine; 
					appendText=	"Grupo" + date.ToString () +Gestao_Players.perfil2.jogador+ ", " + Gestao_Players.perfil2.idade.ToString () + ", " + Gestao_Players.perfil2.sexo.ToString () + ", " + Gestao_Players.perfil2.anoEscolar + ", " + itemMau + ", " + itemBom + ", " + tempo + ", " + vida + ", " + (nivel - 1) + ", " + pontos + ", " + contagem + ", " + "Nao" + Environment.NewLine;
					File.WriteAllText (pathMulti, createText);
					
								}
				
						}
						if (contarBom == numeroItemsBons && nivel == 6) {
				
				appendText ="Grupo" + date.ToString () +Gestao_Players.perfil1.jogador+ ", " + Gestao_Players.perfil1.idade.ToString () + ", " + Gestao_Players.perfil1.sexo.ToString () + ", " + Gestao_Players.perfil1.anoEscolar + ", " + itemMau + ", " + itemBom + ", " + tempo + ", " + vida + ", " + (nivel - 1) + ", " + pontos + ", " + contagem + ", " +"Sim" + Environment.NewLine;
				appendText=	"Grupo" + date.ToString () +Gestao_Players.perfil2.jogador+ ", " + Gestao_Players.perfil2.idade.ToString () + ", " + Gestao_Players.perfil2.sexo.ToString () + ", " + Gestao_Players.perfil2.anoEscolar + ", " + itemMau + ", " + itemBom + ", " + tempo + ", " + vida + ", " + (nivel - 1) + ", " + pontos + ", " + contagem + ", " +	"Sim" + Environment.NewLine;		
				File.AppendAllText (pathMulti, appendText);
						}

				}
		}

}

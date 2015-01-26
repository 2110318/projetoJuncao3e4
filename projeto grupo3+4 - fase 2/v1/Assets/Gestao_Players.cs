using UnityEngine;
using System.Collections;
using System;
using System.IO;
using UnityEngine.UI;
public class Gestao_Players : MonoBehaviour
{
	public static Gestao_Perfis perfil1 = new Gestao_Perfis ();
	public static Gestao_Perfis perfil2 = new Gestao_Perfis ();
	private Gestao_Perfis perfilAtual;
	public static bool isMultiPlayer;
	public Text jogadorTxt;
		// Use this for initialization
		void Start ()
		{

				perfil1.jogador = "jogador1";
				jogadorTxt.text = "Player 1";
				perfilAtual = perfil1;
		}
	
		// Update is called once per frame
		void Update ()
		{

		}

		public void Jogar ()
		{
			
				if (isMultiPlayer) {
						if (perfilAtual != perfil2){
								perfil2.jogador= "jogador2";
								jogadorTxt.text = "Player 2";
								perfilAtual = perfil2;
			}else 
								Application.LoadLevel ("Selecionar_Player");
				} else
						Application.LoadLevel ("Selecionar_Player");
			

		
		}
		

		public void SeisAnos ()
		{
				perfilAtual.SeisAnos ();
		
		}
	
		public void SeteAnos ()
		{
				perfilAtual.SeteAnos ();
		}

		public void OitoAnos ()
		{
				perfilAtual.OitoAnos ();
		}
	
		public void NoveAnos ()
		{
				perfilAtual.NoveAnos ();
		}

		public void DezAnos ()
		{
				perfilAtual.DezAnos ();
		}
	
		public void OnzeAnos ()
		{
				perfilAtual.OnzeAnos ();
		}
	
		public void DozeAnos ()
		{
				perfilAtual.DozeAnos ();
		}
	
		public void PrePrimaria ()
		{
				perfilAtual.PrePrimaria ();
		}
	
		public void PrimeiroAno ()
		{
				perfilAtual.PrimeiroAno ();
		}
	
		public void SegundoAno ()
		{
				perfilAtual.SegundoAno ();
		}
	
		public void TerceiroAno ()
		{
				perfilAtual.TerceiroAno ();
		}

		public void QuartoAno ()
		{
				perfilAtual.QuartoAno ();
		}
	
		public void QuintoAno ()
		{
				perfilAtual.QuintoAno ();
		}
	
		public void SextoAno ()
		{
				perfilAtual.SextoAno ();
		}
	
		public void SetimoAno ()
		{
				perfilAtual.SetimoAno ();
		}
	
		public void SexoFeminino ()
		{
				perfilAtual.SexoFeminino ();
		}

		public void SexoMasculino ()
		{
				perfilAtual.SexoMasculino ();
		}
}

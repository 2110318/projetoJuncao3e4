
using System.Collections;
using System;
using System.IO;

public class Gestao_Perfis {

	public  string anoEscolar = "";
	public  string sexo = "";
	public  int idade;
	//public  DateTime date = DateTime.Now;
	public string jogador="";

	public void SeisAnos(){
		this.idade=6;
		
	}
	
	public void SeteAnos(){
		idade = 7;
	}
	public void OitoAnos(){
		idade = 8;
	}
	
	public void NoveAnos(){
		idade = 9;
	}
	public void DezAnos(){
		idade = 10;
	}
	
	public void OnzeAnos(){
		idade = 11;
	}
	
	public void DozeAnos(){
		idade = 12;
	}
	
	public void PrePrimaria(){
		anoEscolar = "Pre-Primaria";
	}
	
	public void PrimeiroAno(){
		anoEscolar = "Primeiro Ano";
	}
	
	public void SegundoAno(){
		anoEscolar = "Segundo Ano";
	}
	
	public void TerceiroAno(){
		anoEscolar = "Terceiro Ano";
	}
	public void QuartoAno(){
		anoEscolar = "Quarto Ano";
	}
	
	public void QuintoAno(){
		anoEscolar = "Quinto Ano";
	}
	
	public void SextoAno(){
		anoEscolar = "Sexto Ano";
	}
	
	public void SetimoAno(){
		anoEscolar = "Setimo Ano";
	}
	
	public void SexoFeminino(){
		sexo = "Feminino";
	}
	public void SexoMasculino(){
		sexo = "Masculino";
	}
}

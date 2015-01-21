using UnityEngine;
using System.Collections;

public class MenuBotao : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	
	void OnGUI(){
		GUI.Window (0, new Rect ((Screen.width/2)-90, (Screen.height/2)-200, 200, 400),option,"");
		GUI.TextArea (new Rect ((Screen.width / 2) - 90, (Screen.height / 2) - 200, 200, 400), "");
	}
	
	void option(int id){
		

		if (GUI.Button (new Rect (58, 85, 100, 50),"Single-Player")) {
			PlayerPrefs.SetString("Player","Single");
			Application.LoadLevel("Perfis");		
		}
		if (GUI.Button (new Rect (58, 180, 100, 50),"Multi - Player")) {
			PlayerPrefs.SetString("Player","Multi");
			Application.LoadLevel("perfis");		
		}

		if (GUI.Button (new Rect (58, 270, 100, 50),"Sair")) {
			Application.LoadLevel("InterfacePrincipal");		
		}
		
	}
}
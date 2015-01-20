using UnityEngine;
using System.Collections;

public class Selecionar_Player_script : MonoBehaviour {

//these are simply pieces of geometry with an alpha texture on them. 
//You can create any kind of glow geometry to fit your character, vehicle, etc.
public GameObject character1Glow ;
public GameObject character2Glow;
public GameObject character3Glow;
public GameObject character4Glow;

void Start()
{
character1Glow.renderer.enabled = false;  // We're going to make sure all of the highlighted glows are OFF at scene start.
character2Glow.renderer.enabled = false;
character3Glow.renderer.enabled = false;
character4Glow.renderer.enabled = false;
}

void Update() 
{ 
if (Input.GetMouseButtonUp (0)) {
	Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
	RaycastHit hit = new RaycastHit();
	
	if (Physics.Raycast( ray))//(ray, hit, 100))
		{
				// The pink text is where you would put the name of the object you want to click on (has attached collider).
				
	            if(hit.collider.tag == "_Character1") 
				SelectedCharacter1(); //Sends this click down to a function called "SelectedCharacter1(). Which is where all of our stuff happens.
			
				if(hit.collider.tag == "_Character2")
				SelectedCharacter2();
					
				if(hit.collider.tag == "_Character3")
				SelectedCharacter3();
		
				if(hit.collider.tag == "_Character4")
				SelectedCharacter4();
		}                
	} 
}

void SelectedCharacter1() {
				Debug.Log ("Character 1 SELECTED"); //Print out in the Unity console which character was selected.
				character1Glow.renderer.enabled = true; //these lines turn on or off the appropriate character glow.
				character2Glow.renderer.enabled = false;
				character3Glow.renderer.enabled = false;
				character4Glow.renderer.enabled = false; 
}

void SelectedCharacter2() {
				Debug.Log ("Character 2 SELECTED");
				character2Glow.renderer.enabled = true;
				character1Glow.renderer.enabled = false;
				character3Glow.renderer.enabled = false;
				character4Glow.renderer.enabled = false;
}

void SelectedCharacter3() {
				Debug.Log ("Character 3 SELECTED");
				character3Glow.renderer.enabled = true;
				character1Glow.renderer.enabled = false;
				character2Glow.renderer.enabled = false;
				character4Glow.renderer.enabled = false;
}

void SelectedCharacter4() {
				Debug.Log ("Character 4 SELECTED");
				character4Glow.renderer.enabled = true;
				character3Glow.renderer.enabled = false;
				character2Glow.renderer.enabled = false;
				character1Glow.renderer.enabled = false;
}
}

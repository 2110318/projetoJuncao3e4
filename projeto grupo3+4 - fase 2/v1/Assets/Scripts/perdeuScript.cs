using UnityEngine;
using System.Collections;

public class perdeuScript : MonoBehaviour {

    public PickUpItems player;
   
    // Use this for initialization
	void Start () {        
           
	}
	
	// Update is called once per frame
	void Update () {
        if (Time.timeSinceLevelLoad > 3)
        {
            Application.LoadLevel("Interface_Texto");
            player.reiniciar();   
        }
	}
}

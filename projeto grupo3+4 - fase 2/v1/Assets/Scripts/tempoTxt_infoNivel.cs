using UnityEngine;
using System.Collections;

public class tempoTxt_infoNivel : MonoBehaviour {

    private bool iterar = true;
    private float deltaTempo;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (iterar)
        {
            if (Time.timeSinceLevelLoad > deltaTempo + 3)
            {                
                this.guiText.enabled = false;
                iterar = false;
                
            }
            
        }
	}
   
	public void acabouOTempo()
	{
        deltaTempo = Time.timeSinceLevelLoad;
		this.guiText.text = "Acabou o Tempo";       
        iterar = true;
        this.guiText.color = Color.red;
        this.guiText.enabled = true;
        deltaTempo = Time.timeSinceLevelLoad;
	}
}

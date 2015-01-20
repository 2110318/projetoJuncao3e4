using UnityEngine;
using System.Collections;

public class tempoScript : MonoBehaviour {

	private int tempoJogo;
    private int tempoVida;
    public VidasScript vidas;
    	
    public int tempoNivel;
	public tempoTxt_infoNivel txt_infoNivel;

    

	// Use this for initialization
	void Start () {
        tempoVida = tempoNivel;
	}
	
	// Update is called once per frame
	void Update () {
		tempoJogo = (int) (tempoVida - Time.timeSinceLevelLoad);

        if (tempoJogo >= 0)
        {

            this.guiText.text = (tempoJogo / 60).ToString("00") + (tempoJogo % 60).ToString(":00");
        }

		if (tempoJogo == 0) {  
						txt_infoNivel.acabouOTempo();
                       
						
		} else if(tempoJogo==-3)
        {

            reiniciarNivel();
            
        }
        
        
	}

    public void reiniciarNivel()
    {
        tempoVida = (int)Time.timeSinceLevelLoad + tempoNivel + 1;
        vidas.decrementarVidas();
    }
}

using UnityEngine;
using System.Collections;

public class itemTextContadorScript : MonoBehaviour {

	public int numItens;
	private int numItensApanhados;

	// Use this for initialization
	void Start () {
        atualizarTexto();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void incrementarContagem()
	{
			numItensApanhados++;

            if (numItens == numItensApanhados)
                this.guiText.color = Color.green;

            atualizarTexto();
            
	}

    private void atualizarTexto()
    {
        this.guiText.text = numItensApanhados + "/" + numItens;
    }
}

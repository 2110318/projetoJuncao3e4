using UnityEngine;
using System.Collections;

public class PickUpObjects : MonoBehaviour {

    public int score;
    public int count;
	public GUITexture heart1;
	public GUITexture heart2;
	public GUITexture heart3;

	public  int LIVES =0;

    public GUIText txt_score;
    void strat()
    {
        score = 0;
	}

	void GameOver ()
	{
		throw new System.NotImplementedException ();
	}

	void LivesUpdate ()
	{
		switch (LIVES) 
		{
		case 0:GameOver();
			break;
		case 1:	heart1.gameObject.SetActive(true);
			break;
		case 2:heart2.gameObject.SetActive(true);
			break;
		case 3:heart3.gameObject.SetActive(true);
			break;
		}
	}

    private void OnTriggerEnter(Collider other)
    {
		LIVES++;
		LivesUpdate();

        if (other.gameObject.tag == "Item")
        {
            other.gameObject.SetActive(false);
            count++;
            if (other.name == "ItemBom")
                score += 10;
            else{
                score -= 5;

			}
            txt_score.text = "PONTUAÇÃO: " + score;
                
        }
    }
}

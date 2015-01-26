using UnityEngine;
using System.Collections;

public class buttonPlay_script : MonoBehaviour {
	
	public int numPlayers;
	public GUIText playerTxt;
	// Use this for initialization
	void Start()
	{
		
		if (PlayerPrefs.GetString("Player").Equals("Single"))
			numPlayers = 1;
		else if (PlayerPrefs.GetString("Player").Equals("Multi"))
			numPlayers = 2;
		else
			numPlayers = 5;
		
		playerTxt.text = "Player " + numPlayers;
	}
	
	// Update is called once per frame
	void Update()
	{
		
	}
	
	void OnMouseDown()
	{
		
		numPlayers--;
		if (numPlayers == 0)
		{
			PlayerPrefs.SetString("P2", PlayerPrefs.GetString("PlayerSelected"));
			Application.LoadLevel("Nivel_0");
		}
		else
		{
			PlayerPrefs.SetString("P1", PlayerPrefs.GetString("PlayerSelected"));
			playerTxt.text = "Player 1";
		}
		
	}
}

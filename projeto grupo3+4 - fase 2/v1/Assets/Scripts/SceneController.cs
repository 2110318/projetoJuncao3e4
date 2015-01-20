using UnityEngine;
using System.Collections;

public class SceneController : MonoBehaviour {
	private bool debugParticles = true;
	private GameObject effects;
	
	// Use this for initialization
	void Start () {
		StartCoroutine(ResetMachine());
		effects = GameObject.Find("Effects");
	}
	
	// Update is called once per frame
	void Update () {
		effects.SetActive(debugParticles);
	}
	
	void OnGUI () {
		if (GUILayout.Button("RESET"))
            Application.LoadLevel(Application.loadedLevel);
		debugParticles = GUILayout.Toggle(debugParticles, "Effects?");
	}
	
	IEnumerator ResetMachine () {
		yield return new WaitForSeconds(60);
		Application.LoadLevel(Application.loadedLevel);
	}
}

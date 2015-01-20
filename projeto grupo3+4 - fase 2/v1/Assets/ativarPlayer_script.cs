using UnityEngine;
using System.Collections;

public class ativarPlayer_script : MonoBehaviour {

    public GameObject P1;
    public GameObject P2;
    public GameObject P3;
    public GameObject P4;
    
	// Use this for initialization
	void Start () {
        AutoCam cam = GetComponent<AutoCam>();
        switch (PlayerPrefs.GetString("Player"))
        {
            case "1": P1.SetActive(true);
                cam.SetTarget(P1.transform);
                break;
            case "2": P2.SetActive(true);
                cam.SetTarget(P2.transform);
                break;
            case "3": P3.SetActive(true);
                cam.SetTarget(P3.transform);
                break;
            case "4": P4.SetActive(true);
                cam.SetTarget(P4.transform);
                break;
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

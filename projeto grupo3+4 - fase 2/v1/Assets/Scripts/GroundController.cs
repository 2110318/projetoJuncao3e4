using UnityEngine;
using System.Collections;

public class GroundController : MonoBehaviour {
	
	public float speed = 0.35f;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.back * Time.deltaTime * speed);
	}
}

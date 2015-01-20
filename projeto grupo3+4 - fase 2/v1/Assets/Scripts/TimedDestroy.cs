using UnityEngine;
using System.Collections;

public class TimedDestroy : MonoBehaviour {
	
	private float lifetime;

	void Start () 
	{
		GameObject.Destroy(gameObject, particleSystem.startLifetime);
	}
}

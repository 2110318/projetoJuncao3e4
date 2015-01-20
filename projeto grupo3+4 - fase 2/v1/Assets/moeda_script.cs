using UnityEngine;
using System.Collections;

public class moeda_script : MonoBehaviour
{

    public AudioClip somMoeda;

    private float deltaTime;
    // Use this for initialization
    void Start()
    {

        deltaTime = Time.timeSinceLevelLoad;
        //gameObject.rigidbody.AddForce(new Vector3(0, 500, 0));
        gameObject.rigidbody.AddForce(new Vector3(Random.Range(-250, 250), 300, Random.Range(-250, 250)));

    }
    private void OnCollisionEnter(Collision collision)
    {
        AudioSource.PlayClipAtPoint(somMoeda, transform.position);

    }

    // Update is called once per frame
    void Update()
    {

        if (deltaTime + 1 < Time.timeSinceLevelLoad)
        {
            GetComponent<SphereCollider>().enabled = true;
        }
    }
}

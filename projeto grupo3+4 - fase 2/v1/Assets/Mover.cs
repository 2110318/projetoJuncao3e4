using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour {

    public float speed;

    private void FixedUpdate()
    {
        float movoHorizontal = Input.GetAxis("Horizontal");
        float movoVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(movoHorizontal, 0.0f, movoVertical);

        rigidbody.AddForce(movement * speed * Time.deltaTime);

    }
}

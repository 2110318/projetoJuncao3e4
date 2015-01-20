using UnityEngine;
using System.Collections;

public class abanarBarcoScript : MonoBehaviour {

    bool abanar;
    int iterar = 0;
    int rodar = 5;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (abanar)
        {
            if (iterar == 60)
                rodar = 5;
            if (iterar == -60)
                rodar = -5;

            if (rodar == 5)
                iterar--;
            if (rodar == -5)
                iterar++;

            this.transform.Rotate(Vector3.up, rodar * Time.deltaTime);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        abanar = true;
    }

    private void OnTriggerExit(Collider other)
    {
        abanar = false;
    }
}

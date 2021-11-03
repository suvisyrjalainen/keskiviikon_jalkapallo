using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        Vector3 aloituspaikka = new Vector3(0, 0, 0);

        if (other.gameObject.tag == "maali1")
        {
            Debug.Log("Ykköset saivat maalin");
            transform.position = aloituspaikka;
            rigidbody.velocity = Vector3.zero;
            rigidbody.angularVelocity = Vector3.zero;
        }

        if (other.gameObject.tag == "maali2")
        {
            Debug.Log("Kakkoset saivat maalin");
            transform.position = aloituspaikka;
            rigidbody.velocity = Vector3.zero;
            rigidbody.angularVelocity = Vector3.zero;
        }

    }
}









































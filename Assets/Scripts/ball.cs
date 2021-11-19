using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    Rigidbody rigidbody;

    public GUISkin Pisteet1;
    private static int Joukkue1_pisteet = 0;
    string pisteet_1 = "Joukkue 1 Pisteet: " + Joukkue1_pisteet;

    public GUISkin Pisteet2;
    private static int Joukkue2_pisteet = 0;
    string pisteet_2 = "Joukkue 2 Pisteet: " + Joukkue2_pisteet;


    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnGUI()
    {
        GUI.skin = Pisteet1;
        GUI.Label(new Rect(100, 0, 200, 100), pisteet_1);

        GUI.skin = Pisteet2;
        GUI.Label(new Rect(400, 0, 200, 100), pisteet_2);
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

            Joukkue1_pisteet += 1;
            pisteet_1 = "Joukkue 1 Pisteet: " + Joukkue1_pisteet;
        }

        if (other.gameObject.tag == "maali2")
        {
            Debug.Log("Kakkoset saivat maalin");
            transform.position = aloituspaikka;
            rigidbody.velocity = Vector3.zero;
            rigidbody.angularVelocity = Vector3.zero;

            Joukkue2_pisteet += 1;
            pisteet_2 = "Joukkue 2 Pisteet: " + Joukkue2_pisteet;
        }

    }


}









































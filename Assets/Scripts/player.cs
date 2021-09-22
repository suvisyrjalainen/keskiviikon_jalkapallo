using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{

    CharacterController hahmokontrolleri;
    // Start is called before the first frame update
    void Start()
    {
        hahmokontrolleri = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        //Eteenpäin ja sivulle liikkuminen
        float horizontal = Input.GetAxis("Horizontal") * 3;
        float vertical = Input.GetAxis("Vertical") * 3;
        Vector3 nopeus = new Vector3(horizontal, 0, vertical);


        //liikkutaan komento
        hahmokontrolleri.Move(nopeus * Time.deltaTime);


    }
}

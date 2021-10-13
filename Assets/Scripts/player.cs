using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{

    CharacterController hahmokontrolleri;
    // Start is called before the first frame update

    Animator anim;

    private float horisontaalinenPyorinta = 0;
    private float painovoima = 10f;

    private float speed = 5f;

    void Start()
    {
        hahmokontrolleri = GetComponent<CharacterController>();
        anim = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //Eteenpäin ja sivulle liikkuminen
        float horizontal = Input.GetAxis("Horizontal") * speed;
        float vertical = Input.GetAxis("Vertical") * speed;
        Vector3 nopeus = new Vector3(horizontal, 0, vertical);

        //hiiren x verran pyöriminen
        horisontaalinenPyorinta += Input.GetAxis("Mouse X");
        transform.localRotation = Quaternion.Euler(0, horisontaalinenPyorinta, 0);
        nopeus = transform.rotation * nopeus;

        //painovoima
        nopeus.y -= painovoima;

        //liikkutaan komento
        hahmokontrolleri.Move(nopeus * Time.deltaTime);

        if (Input.GetAxis("Vertical") > 0)
        {
            anim.SetBool("Run_F", true);
            speed = 8;
        }
        else if (Input.GetAxis("Vertical") < 0 || Input.GetAxis("Horizontal") != 0)
        {
            anim.SetBool("Run_B", true);
            speed = 4;
        }
        else
        {
            anim.SetBool("Run_F", false);
            anim.SetBool("Run_B", false);
        }


        }
}

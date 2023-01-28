using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class kontrol : MonoBehaviour
{
    public Animator animasyon;
    public Vector3 position;
    Rigidbody rigi;
    bool sað = true;

 
    
    private Animator anim;
    private CharacterController controller;
    public float speed = 600.0f;
    public float turnSpeed = 400.0f;
    private Vector3 moveDirection = Vector3.zero;
    public float gravity = 20.0f;


    private void Start()
    {
        rigi = GetComponent<Rigidbody>();
        anim = gameObject.GetComponent<Animator>();
    }

    void Update()
    {

        anim.SetBool("run", true);
        hareket();

    }

    void hareket()
    {
        transform.Translate(0, 0, 20 * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            sað = true;
            
        }
        if (Input.GetKey("a"))
        {
            sað = false;
            
        }

        if (sað)
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3(3.30f, transform.position.y, transform.position.z), Time.deltaTime * 3.0f);
        }
        else
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3(-3.30f, transform.position.y, transform.position.z), Time.deltaTime * 3.0f);
        }
       
    }




}



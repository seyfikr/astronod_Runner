using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kod : MonoBehaviour
{

    public GameObject tozefekti;
    public GameObject kristalefekti;
    public GameObject bitis;

    public TMPro.TextMeshProUGUI puantxt;
    public TMPro.TextMeshProUGUI toplanankristal;

    public Rigidbody rigi;

    bool sag = true;

    int puan = 0;
    int kristal = 0;


    public Transform yol1;
    public Transform yol2;
    public Transform yol3;
    public Transform yol4;




    private void OnTriggerEnter(Collider other)
    {
        transform.position += new Vector3(0, 0, 0 + 113.76f);

       



    }

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    
   
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{

    private GameObject a;
    public GameObject kristal1;
    public GameObject kristal2;
    public GameObject kristal3;
    public GameObject kristal4;
    public GameObject benzin;
    public GameObject tas;
    public GameObject uzayli;

    public Transform astronot;

    float silinmezamani = 5.0f;
    float sag_x_koordinat = 3.13f;
    float sol_x_koordinat = -3.13f;


    void Start()
    {

        InvokeRepeating("nesne_klonla", 0, 0.5f);
        

    }

    void nesne_klonla()
    {
        int rastsayi = Random.Range(0, 100);

        if(rastsayi>95 && rastsayi < 100 || rastsayi > 30 && rastsayi < 35)
        {
            klonla(kristal1, 0f);
        }
        if (rastsayi > 80 && rastsayi < 85 || rastsayi > 25 && rastsayi < 30 )
        {
            klonla(kristal2, 0f);
        }
        if (rastsayi > 85 && rastsayi < 90 || rastsayi > 20 && rastsayi < 25 )
        {
            klonla(kristal3, 0f);
        }
        if (rastsayi > 90 && rastsayi < 95 || rastsayi > 15 && rastsayi < 20)
        {
            klonla(kristal4, 0f);
        }
        if (rastsayi > 75 && rastsayi < 80 || rastsayi > 10 && rastsayi < 15)
        {
            klonla(benzin, 0f);
        }
        if (rastsayi > 70 && rastsayi < 75 || rastsayi > 5 && rastsayi < 10 || rastsayi > 35 && rastsayi < 40 || rastsayi > 45 && rastsayi < 50)
        {
            klonla(tas, 0f);
        }
        if (rastsayi > 65 && rastsayi < 70 || rastsayi > 0 && rastsayi < 5 || rastsayi > 50 && rastsayi < 55 || rastsayi > 40 && rastsayi < 45 )
        {
            klonla(uzayli, 0f);
            
        }

      
    }

    void klonla(GameObject nesne, float y_koordinat)
    {
        GameObject yeni_klon = Instantiate(nesne);

        int rastsayi = Random.Range(0, 100);

        if(rastsayi< 50)
        {
            yeni_klon.transform.position = new Vector3(sag_x_koordinat, y_koordinat, astronot.position.z + 27.0f);
        }
        else if(rastsayi > 50)
        {
            yeni_klon.transform.position = new Vector3(sol_x_koordinat, y_koordinat, astronot.position.z + 27.0f);
        }

        Destroy(yeni_klon, silinmezamani);


    




    }









    
    void Update()
    {
        
    }
}

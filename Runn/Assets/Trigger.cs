using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trigger : MonoBehaviour
     
{
   
    private  int kristall = 0;
    private int benzinpuan = 0;
    public Text kristaltext;
    public Text benzintext;
    public GameObject panel;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        kristaltext.text = "Kristal Puaný:" + kristall.ToString();
        benzintext.text = "Benzin Puaný:" + benzinpuan.ToString();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "kristal")
        {
            kristall++;
            Debug.Log(kristall);
            Destroy(other.gameObject);

        }
        if (other.tag == "kristal2")
        {
            kristall = kristall + 3;
            Debug.Log(kristall);
            Destroy(other.gameObject);

        }
        if (other.tag == "kristal3")
        {
            kristall = kristall + 5;
            Debug.Log(kristall);
            Destroy(other.gameObject);

        }
        if (other.tag == "kristal4")
        {
            kristall=kristall+7;
            Debug.Log(kristall);

            Destroy(other.gameObject);
        }
        if(other.tag == "benzin")
        {
            benzinpuan++;
            Debug.Log(benzinpuan);
            Destroy(other.gameObject);
        }
        if (other.tag == "lose")
        {
            Time.timeScale = 0;
            panel.SetActive(true);
            
        }
       
    }
}

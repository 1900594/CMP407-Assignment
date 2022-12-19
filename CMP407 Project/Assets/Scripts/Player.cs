using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Player : MonoBehaviour
{


    private int Collectables;

  

    

    public Text countText;

    // Start is called before the first frame update
    void Start()
    {
        Collectables = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
           // Debug.Log("You Have:  " + Collectables + "Collectables");
        }

        countText.text = Collectables.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Collectable")
        {

            Collectables++;
            other.gameObject.SetActive(false);
            
            
        }

        if(other.gameObject.tag=="ReverbZone")
        {
            Debug.Log("Reverb!");
        }

     
    }

 

    public int ReturnCollectables()
    {
        return Collectables;
    }



}

using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Player : MonoBehaviour
{


    private int Collectables;

    public GameObject SecretWall;

    private bool bSecretTrigger = false;


    public AK.Wwise.Event StopStarSound = new AK.Wwise.Event();
    
    

    public Text countText;

    public Text WinText;

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

        TriggerSecret();

    
        countText.text = Collectables.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Collectable")
        {

            Collectables++;
            StopStarSound.Stop(other.gameObject);
            other.gameObject.SetActive(false);
            
        }

        /*if(other.gameObject.tag=="ReverbZone")
        {
            Debug.Log("Reverb!");
        }*/

        if(other.gameObject.tag=="Secret")
        {
            bSecretTrigger = true;
        }

        if (other.gameObject.tag == "Chest")
        {
            //play sound with audio effect
            Debug.Log("Treasure!");
            // TreasureSound.Post(other.gameObject);
            //load end state with coroutine

     
        }

    }

 

    void TriggerSecret()
    {
        if(Collectables >= 1 && bSecretTrigger == true)
        {
            SecretWall.SetActive(false);
        }
    }

    public int ReturnCollectables()
    {
        return Collectables;
    }



}

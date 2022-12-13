using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{


    private int Collectables;
    // Start is called before the first frame update
    void Start()
    {
        Collectables = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("You Have:  " + Collectables + "Collectables");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Collectable")
        {

            Collectables++;
            other.gameObject.SetActive(false);
        }
    }

}

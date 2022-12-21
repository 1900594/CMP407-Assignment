using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecretWallScript : MonoBehaviour
{

    public Player player;
    public GameObject SecretWall;
    

    // Start is called before the first frame update
    void Start()
    {
        //player.FindObjectOfType<Player>(); 
        player.GetComponent<Player>();
        //CheckCollectable();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void CheckCollectable()
    {
        if (player.ReturnCollectables() >= 1)//if collectibles collected is greater than or equal to 5
        {
            //secret wall should disappear...
            SecretWall.SetActive(false); 
          
        }
    }
}

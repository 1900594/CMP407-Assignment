using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuUI : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


   public void PlayButton()
    {
        SceneManager.LoadScene("SampleScene");
        Debug.Log("Level Loaded");
    }
}
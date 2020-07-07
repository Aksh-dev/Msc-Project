using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading;

public class animation : MonoBehaviour
{
    private float waitTime = 4.5f;
    private float timer = 0.0f;
    public GameObject car;
    public GameObject panel;
  
    public void Update()
    {
        timer += Time.deltaTime;
        // Check if we have reached beyond 4.5 seconds.
        
        if (timer > waitTime )
        {
            car.SetActive(false);
            panel.SetActive(true);
            
        }
       
    }
}
            

            
        
    



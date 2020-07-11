using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class buttonClick : MonoBehaviour
{
        public GameObject button1;
        public GameObject button2;
        public GameObject button3;

    String path = "Assets/Resources/da.txt";

    public void Update()
        {

      
        if (Input.GetMouseButtonDown(0) && EventSystem.current.currentSelectedGameObject == button1)
            {
            
            //Writing text to the file.
            TextWriter tsw = new StreamWriter(@"Assets/Resources/data.csv",true);
            tsw.WriteLine(button1.name);
            tsw.Close();
            SceneManager.LoadScene("Menu");
        }
        
        else if (Input.GetMouseButtonDown(0) && EventSystem.current.currentSelectedGameObject == button2)
            {
            TextWriter tsw = new StreamWriter(@"Assets/Resources/data.csv",true);
            tsw.WriteLine(button2.name);
            tsw.Close();
            SceneManager.LoadScene("Menu");
        }
        
        else if (Input.GetMouseButtonDown(0) && EventSystem.current.currentSelectedGameObject == button3)
            {
            TextWriter tsw = new StreamWriter(@"Assets/Resources/data.csv", true);
            tsw.WriteLine(button3.name);
            tsw.Close();
            SceneManager.LoadScene("Menu");
        }
        }
    }


    


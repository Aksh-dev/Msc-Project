using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading;

public class wait : MonoBehaviour
{
    public void Start()
     {
       StartCoroutine(test());
     }
   
    IEnumerator test()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("Menu");

    }
}

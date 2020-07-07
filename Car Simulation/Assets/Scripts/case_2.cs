using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class case_2 : MonoBehaviour
{
    private float waitTime = 5.5f;
    private float timer = 0.0f;
    public GameObject car;
    public GameObject panel;

    void Update()
    {
        timer += Time.deltaTime;

        // Check if we have reached beyond 10 seconds.

        if (timer > waitTime)
        {
            car.SetActive(false);
            panel.SetActive(true);
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class countdownTest : MonoBehaviour
{
    countdown cs;
    float startingTime;
    float elapsedTime;

    // Start is called before the first frame update
    void Start()
    {
        cs = gameObject.AddComponent<countdown>();
        cs.TotalTime = 3;
        cs.Execute();
        startingTime = Time.time; // Real world time based 
    }

    // Update is called once per frame
    void Update()
    {
        if (cs.Done)
        {
            Debug.Log(Time.time - startingTime); //elapsed time will be approximately 3 sec

            startingTime = Time.time;
            cs.Execute();
        }
    }
}

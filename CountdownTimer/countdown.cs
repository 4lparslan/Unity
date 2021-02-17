using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class countdown : MonoBehaviour
{
    float totalTime = 0;
    float elapsedtime = 0;

    bool working = false;
    bool isBegan = false;

    /// <summary>
    /// It sets the countdown timer's total time 
    /// </summary>
    public float TotalTime
    {
        set
        {
            if (!working)
            {
                totalTime = value;
            }
        }
    }

    /// <summary>
    /// Returns whether or not counting down over
    /// </summary>
    public bool Done
    {
        get
        {
            return isBegan && !working;
        }
    }

    /// <summary>
    /// It starts the counter
    /// </summary>
    public void Execute()
    {
        if(totalTime > 0)
        {
            working = true;
            isBegan = true;
            elapsedtime = 0;
        }
    }

    void Update()
    {
        if (working)
        {
            elapsedtime += Time.deltaTime; // Time is passing frame by frame

            if (elapsedtime > totalTime) // Time is up!
                working = false;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConventionsAndSyntax : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //i want the x position of my GameObject to appear on the console
        Debug.Log(transform.position.x);
    }

    // Update is called once per frame
    void Update()
    {
        //i want the y position of my GameObject to appear on the console
        //Debug.Log(transform.position.y);

        //I want the console to say something if my object is bellow five
        if(transform.position.y <= 5f)
        {
            Debug.Log("i am about to hit the ground");
        }
    }
}

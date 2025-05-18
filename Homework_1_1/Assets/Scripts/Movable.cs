using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Movable : MonoBehaviour
{
    bool up;
    int Temp;
    void Start()
    {
        Temp = 1;
        Debug.Log("Start game");
    }

 
    void Update()
    {
        
        float y = GameObject.Find("Sphere").transform.position.y;

        if (y > 4) Temp = 0;
        else if (y < 3.5) Temp = 1;

        if (Temp == 1)
        {
            transform.Translate(0, 0.001f, 0);
        }
        else if (Temp == 0)
        {
            transform.Translate(0, -0.001f, 0);
        }


    }
}

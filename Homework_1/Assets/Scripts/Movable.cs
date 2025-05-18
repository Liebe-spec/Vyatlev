using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movable : MonoBehaviour
{
    bool up; 

    void Start()
    {
        Debug.Log("Start game");
    }

 
    void Update()
    {

        transform.Translate(0, 0.1f, 0);
        transform.Rotate(0, 90 / 60f, 0); 
    }
}

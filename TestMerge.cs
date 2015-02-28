// what if i have some code and two people are working on it at the same time.
// BH is working on the void Start() method.
// and BF is working on the void Update() method.

using UnityEngine;
Using System.Collections.Generic;

public class TestMerge : MonoBehaviour
{
    void Start()
    { 
  		Debug.Log("This is BH messing with stuff.");
    }
  
    void Update()
    {
        Debug.Log("This is BF messing with stuff.");
    }
}

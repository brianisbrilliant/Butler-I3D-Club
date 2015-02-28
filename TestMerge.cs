// what if i have some code and two people are working on it at the same time.
// BH is working on the void Start() method.
// and BF is working on the void Update() method.

using UnityEngine;
Using System.Collections.Generic;

public class TestMerge : MonoBehaviour
{
    void Start()
    { 
        // at the same time, while this window was open and before void Update() was updated
        // I wrote this line of code from the browser editor of GitHub.com
        // now it is synced, and i will sync this as well.
  		Debug.Log("This is BH messing with stuff.");
    }
  
    void Update()
    {
        Debug.Log("This is BF messing with stuff.");
    }
}

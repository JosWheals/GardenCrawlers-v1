using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
         
        
    }

    IEnumerator WaitBeforeNext()
    {
        yield return new WaitForSeconds(7);
        Debug.Log("Worked");
    }
}

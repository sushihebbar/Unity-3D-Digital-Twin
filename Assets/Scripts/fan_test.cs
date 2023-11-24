using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fan_test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       transform.Rotate(0f, Time.deltaTime * 50.0f, 0f);
    }
}

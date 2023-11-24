using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raycast : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Physics.Raycast(transform.position,transform.TransformDirection(Vector3.forward),
            out RaycastHit hitInfo, 20f))
        {
            Debug.Log("hit");
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward)*hitInfo.distance, Color.red);
        }
        else
        {
            Debug.Log("not");
        }
    }
}

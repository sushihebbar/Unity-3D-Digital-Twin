using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class lighttoggle : MonoBehaviour
{
    public GameObject lightObject; // Reference to the light object
    public bool isOn = false;
    void OnMouseDown()
    {
        //isOn = !isOn;
        if (gameObject.CompareTag("LightSwitch"))
        {
            Debug.Log("light switch");
            if (lightObject != null && !isOn)
            {
                //lightObject.SetActive(!lightObject.activeSelf);
                lightObject.SetActive(true);
                Debug.Log(isOn);
            }
            if (lightObject != null && isOn)
            {
                Debug.Log(isOn);
                //lightObject.SetActive(!lightObject.activeSelf);
                lightObject.SetActive(false);
            }
        }
        
    }
    //private void OnTriggerStay(Collider other)
    //{
    //    if (other.CompareTag("Player"))
    //    {
    //        if (Input.GetMouseButtonDown(0))
    //        {
    //            switchOn = !switchOn;
    //            lightObject.SetActive(switchOn);
    //        }
    //    }
    //}
}

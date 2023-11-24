//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class Light : MonoBehaviour
//{
//    public GameObject spotLight;
//    private bool switchOn = false;
//    // Start is called before the first frame update
//    void Start()
//    {

//    }

//    // Update is called once per frame
//    void Update()
//    {
//        //Debug.Log(gameObject.name);
//        //if (Input.GetMouseButtonDown(0) && switchOn==false && gameObject.CompareTag("LightSwitch"))
//        //{
//        //    spotLight.SetActive(true);
//        //    switchOn = true;
//        //}
//        //else if (Input.GetMouseButtonDown(0) && switchOn == true && gameObject.CompareTag("LightSwitch"))
//        //{
//        //    spotLight.SetActive(false);
//        //    switchOn = false;
//        //}
//        if (Input.GetMouseButtonDown(0))
//        {
//            // Cast a ray from the mouse position into the scene
//            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
//            RaycastHit hit;

//            // Check if the ray hits an object
//            if (Physics.Raycast(ray, out hit))
//            {
//                // Check if the hit object has the "LightSwitch" tag
//                if (hit.collider.gameObject.CompareTag("LightSwitch"))
//                {
//                    // Toggle the light based on the switch state
//                    ToggleLight();
//                }
//            }
//        }
//    }
//    void ToggleLight()
//    {
//        switchOn = !switchOn; // Toggle the switch state

//        if (switchOn)
//        {
//            spotLight.SetActive(true);
//        }
//        else
//        {
//            spotLight.SetActive(false);
//        }
//    }

//}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light : MonoBehaviour
{
    public AudioSource src;
    public AudioClip sfx1;

    public GameObject spotLight;
    private bool switchOn = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(gameObject.name);
        //if (Input.GetMouseButtonDown(0) && switchOn==false && gameObject.CompareTag("LightSwitch"))
        //{
        //    spotLight.SetActive(true);
        //    switchOn = true;
        //}
        //else if (Input.GetMouseButtonDown(0) && switchOn == true && gameObject.CompareTag("LightSwitch"))
        //{
        //    spotLight.SetActive(false);
        //    switchOn = false;
        //}
        if (Input.GetMouseButtonDown(0))
        {
            // Cast a ray from the mouse position into the scene
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            // Check if the ray hits an object
            if (Physics.Raycast(ray, out hit))
            {
                // Check if the hit object has the "LightSwitch" tag
                if (hit.collider.gameObject.CompareTag("LightSwitch"))
                {
                    src.clip = sfx1;
                    src.Play();
                    // Toggle the light based on the switch state
                    ToggleLight();
                }
            }
        }
    }
    void ToggleLight()
    {
        switchOn = !switchOn; // Toggle the switch state

        if (switchOn)
        {
            spotLight.SetActive(true);
        }
        else
        {
            spotLight.SetActive(false);
        }
    }

}
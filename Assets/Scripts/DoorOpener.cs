//using UnityEngine;

//public class DoorOpener : MonoBehaviour
//{
//    [SerializeField] private Animator myDoor = null;
//    [SerializeField] private bool openTrigger = false;
//    [SerializeField] private bool closeTrigger = true;

//    void OnMouseDown()
//    {
//        Debug.Log("hello");
//        if (openTrigger)
//        {
//            Debug.Log("Hello openTrigger");
//            myDoor.Play("openDoor", 0, 0.0f);
//            // Alternatively, you can use myDoor.SetTrigger("openDoor"); if your animation uses a trigger
//        }
//        else if (closeTrigger)
//        {
//            Debug.Log("Hello close");
//            myDoor.Play("closeDoor", 0, 0.0f);
//            //myDoor.SetTrigger("closeDoor");
//        }
//    }
//}
using System.Linq.Expressions;
using Unity.VisualScripting;
using UnityEngine;

public class DoorOpener : MonoBehaviour
{


    [SerializeField] private Animator myDoor = null;
    private bool isOpen = false;
    public AudioSource src;
    public AudioClip sfx1;

    void OnMouseDown()

    {

        Debug.Log("hello");

        // Toggle the door state
        isOpen = !isOpen;

        if (isOpen && gameObject.CompareTag("door"))
        {
            Debug.Log("Hello open");
            src.clip = sfx1;
            src.Play();
            myDoor.Play("openDoor", 0, 0.0f);
            // Alternatively, you can use myDoor.SetTrigger("openDoor"); if your animation uses a trigger
        }
        //if (gameObject.CompareTag("LightSwitch"))
        //{

        //    lightObject.SetActive(true);
        //}

        if (!isOpen && gameObject.CompareTag("door"))
        {
            Debug.Log("Hello close");
            src.clip = sfx1;
            src.Play();
            myDoor.Play("closeDoor", 0, 0.0f);
            //myDoor.SetTrigger("closeDoor");
        }
    }
}
 
    


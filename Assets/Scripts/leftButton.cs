using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class leftButton : MonoBehaviour
{
    bool isPressed = false;
    public GameObject Player;
    public float Force = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isPressed)
        {
            Player.transform.Translate(Force * Time.deltaTime, 0, 0);

        }
    }
    public void OnPointerDown()
    {
        isPressed = true;
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        isPressed = false;
    }
}

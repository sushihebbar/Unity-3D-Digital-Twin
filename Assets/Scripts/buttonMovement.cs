using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class LeftMove : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    bool isPressed = false;
    public GameObject Player;
    public float Force = 2;
    // Update is called once per frame
    void Update()
    {
        if (isPressed)
            Player.transform.Translate(-Force * Time.deltaTime, 0, 0);

    }
    public void OnPointerDown(PointerEventData eventData)
    {
        isPressed = true;
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        isPressed = false;
    }
}

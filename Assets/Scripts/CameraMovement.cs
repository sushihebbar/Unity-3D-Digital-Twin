using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Navigate : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("Movement")]
    [SerializeField] private float moveSpeed = 0.05f;
    [SerializeField] private float moveS = 0.1f;
    [SerializeField] private float rspeed = 2f;

    private CharacterController controller;

    [SerializeField] private KeyCode forwardKey = KeyCode.UpArrow;
    [SerializeField] private KeyCode backKey = KeyCode.DownArrow;
    [SerializeField] private KeyCode leftkey = KeyCode.LeftArrow;
    [SerializeField] private KeyCode rightkey = KeyCode.RightArrow;
    [SerializeField] private KeyCode anchormovekey = KeyCode.Mouse2;
    [SerializeField] private KeyCode anchorrotatekey = KeyCode.Mouse1;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void FixedUpdate()
    {
        Vector3 move = Vector3.zero;
        if (Input.GetKey(forwardKey))
        {
            move = move + Vector3.forward * moveSpeed;
        }
        if (Input.GetKey(backKey))
        {
            move = move + Vector3.back * moveSpeed;
        }
        if (Input.GetKey(leftkey))
        {
            move += Vector3.left * moveSpeed;
        }
        if (Input.GetKey(rightkey))
        {
            move += Vector3.right * moveSpeed;
        }


        float mouseMoveY = Input.GetAxis("Mouse Y");
        float mouseMoveX = Input.GetAxis("Mouse X");
        if (Input.GetKey(anchormovekey))
        {
            move += Vector3.up * mouseMoveY * moveS;
            move += Vector3.right * mouseMoveX * moveS;

        }
        if (Input.GetKey(anchorrotatekey))
        {
            transform.RotateAround(transform.position, transform.right, mouseMoveY * -rspeed);
            transform.RotateAround(transform.position, Vector3.up, mouseMoveX * -rspeed);

        }
        transform.Translate(move);
    }
    void LateUpdate()
    {

    }
}

//using UnityEngine;

//public class Navigate : MonoBehaviour
//{
//    [Header("Movement")]
//    [SerializeField] private float moveSpeed = 0.05f;
//    [SerializeField] private float moveS = 0.1f;
//    [SerializeField] private float rspeed = 2f;
//    public GameObject cam1;
//    public GameObject cam2;

//    private CharacterController controller;

//    [SerializeField] private KeyCode anchorMoveKey = KeyCode.Mouse2;
//    [SerializeField] private KeyCode anchorRotateKey = KeyCode.Mouse1;

//    void Start()
//    {
//        // Add initialization code here if needed
//    }

//    void Update()
//    {
//        HandleTouchInput();
//    }

//    void FixedUpdate()
//    {
//        HandleKeyboardInput();
//    }

//    void HandleTouchInput()
//    {
//        foreach (Touch touch in Input.touches)
//        {
//            if (touch.phase == TouchPhase.Began || touch.phase == TouchPhase.Moved)
//            {
//                // Check if the touch is on the left or right side of the screen for movement
//                if (touch.position.x < Screen.width * 0.5f)
//                {
//                    // Left side for movement
//                    Vector3 move = new Vector3(touch.deltaPosition.x, touch.deltaPosition.y, 0) * moveS * Time.deltaTime;
//                    transform.Translate(move);
//                }
//                else
//                {
//                    // Right side for rotation
//                    float rotateX = touch.deltaPosition.y * -rspeed * Time.deltaTime;
//                    float rotateY = touch.deltaPosition.x * -rspeed * Time.deltaTime;
//                    transform.Rotate(Vector3.up, rotateY);
//                    transform.Rotate(Vector3.right, rotateX);
//                }

//                // Add forward movement for touch on the left side
//                if (touch.position.x < Screen.width * 0.5f)
//                {
//                    Vector3 forwardMove = Vector3.forward * moveSpeed * Time.deltaTime;
//                    transform.Translate(forwardMove);
//                }
//            }
//        }
//    }

//    void HandleKeyboardInput()
//    {
//        Vector3 move = Vector3.zero;
//        if (Input.GetKey(KeyCode.P))
//        {
//            cam1.SetActive(true);
//            cam2.SetActive(false);

//        }
//        if (Input.GetKey(KeyCode.O))
//        {
//            cam1.SetActive(false);
//            cam2.SetActive(true);

//        }
//        if (Input.GetKey(KeyCode.UpArrow))
//        {
//            move += Vector3.forward * moveSpeed;
//        }
//        if (Input.GetKey(KeyCode.DownArrow))
//        {
//            move += Vector3.back * moveSpeed;
//        }
//        if (Input.GetKey(KeyCode.LeftArrow))
//        {
//            move += Vector3.left * moveSpeed;
//        }
//        if (Input.GetKey(KeyCode.RightArrow))
//        {
//            move += Vector3.right * moveSpeed;
//        }

//        float mouseMoveY = Input.GetAxis("Mouse Y");
//        float mouseMoveX = Input.GetAxis("Mouse X");

//        if (Input.GetKey(anchorMoveKey))
//        {
//            move += Vector3.up * mouseMoveY * moveS;
//            move += Vector3.right * mouseMoveX * moveS;
//        }

//        if (Input.GetKey(anchorRotateKey))
//        {
//            transform.RotateAround(transform.position, transform.right, mouseMoveY * -rspeed);
//            transform.RotateAround(transform.position, Vector3.up, mouseMoveX * -rspeed);
//        }

//        transform.Translate(move);
//    }
//}



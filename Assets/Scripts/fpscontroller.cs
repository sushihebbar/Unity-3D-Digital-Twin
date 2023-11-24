using UnityEngine;

public class SimpleFPSController : MonoBehaviour
{
    public float walkSpeed = 5.0f;
    public float mouseSensitivity = 2.0f;
    public bool canJump = true;
    public float jumpForce = 5.0f;

    private Camera playerCamera;
    private CharacterController characterController;
    private float verticalRotation = 0.0f;
    private float verticalVelocity = 0.0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        playerCamera = GetComponentInChildren<Camera>();
        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        // Rotation
        float horizontalRotation = Input.GetAxis("Mouse X") * mouseSensitivity;
        transform.Rotate(0, horizontalRotation, 0);

        verticalRotation -= Input.GetAxis("Mouse Y") * mouseSensitivity;
        verticalRotation = Mathf.Clamp(verticalRotation, -90f, 90f);
        playerCamera.transform.localRotation = Quaternion.Euler(verticalRotation, 0, 0);

        // Movement
        float forwardSpeed = Input.GetAxis("Vertical") * walkSpeed;
        float sideSpeed = Input.GetAxis("Horizontal") * walkSpeed;

        verticalVelocity += Physics.gravity.y * Time.deltaTime;

        if (characterController.isGrounded)
        {
            verticalVelocity = -0.5f;

            // Jumping
            if (canJump && Input.GetButtonDown("Jump"))
            {
                verticalVelocity = jumpForce;
            }
        }

        Vector3 speed = new Vector3(sideSpeed, verticalVelocity, forwardSpeed);
        speed = transform.rotation * speed;

        characterController.Move(speed * Time.deltaTime);
    }
}

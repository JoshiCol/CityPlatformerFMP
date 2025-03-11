using UnityEngine;

public class FreeLookCamera : MonoBehaviour
{
    [Header("Mouse")]
    private float mouseX;
    private float mouseY;

    [Header("Camera Sensitivity")]
    [SerializeField] private float lookSensitivity = 100f;

    [Header("Movement")]
    [SerializeField] private float movementSensitivity = 15f;
    [SerializeField] private float upDownSensitivity = 10f;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        RotateCam();
        MoveCam();
    }

    void MoveCam()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        float moveUp = Input.GetKey(KeyCode.LeftShift) ? -1 : Input.GetKey(KeyCode.Space) ? 1 : 0;

        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical) * movementSensitivity;
        transform.Translate(movement * Time.deltaTime);
        transform.position = new Vector3(transform.position.x, transform.position.y + (moveUp * upDownSensitivity * Time.deltaTime), transform.position.z);
    }

    void RotateCam()
    {
        mouseX += Input.GetAxis("Mouse X") * lookSensitivity * Time.deltaTime;
        mouseY -= Input.GetAxis("Mouse Y") * lookSensitivity * Time.deltaTime;
        transform.localRotation = Quaternion.Euler(mouseY, mouseX, 0);
    }
}

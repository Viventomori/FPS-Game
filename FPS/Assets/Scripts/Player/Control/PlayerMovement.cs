using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] Joystick leftJoystick;
    public CharacterController controller;

    public float speed = 12f;

    private void Start()
    {

    }

    private void Update()
    {
        float x = leftJoystick.Horizontal;
        float z = leftJoystick.Vertical;

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    public Transform playerBody;
    private float xRotation = 0f;
    [SerializeField] private float Sensitivity = 2f;
    [SerializeField] private Joystick rightJoystick;

    private void FixedUpdate()
    {
        float changeX = rightJoystick.Horizontal * Sensitivity;
        float changeY = rightJoystick.Vertical * Sensitivity;

        xRotation -= changeY;
        xRotation = Mathf.Clamp(xRotation, -45f, 45f);
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * changeX);
    }
}

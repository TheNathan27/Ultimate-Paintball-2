﻿using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mouseSensitivity = 100f;

    [SerializeField] Transform playerBody = null;

    float xRotation = 0f;

    void Update()
    {
        if (Cursor.lockState != CursorLockMode.Locked) { return; }

        float _mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float _mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= _mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        playerBody.Rotate(Vector3.up * _mouseX);
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Camerapourmouvement : MonoBehaviour
{
    public float lookupmax = 80;
    public float lookupmin = -80;
    public float lookright = 150;
    public float lookleft = -30;
    float mouseSensitivity = 85.0f;
    float rotationY = 0.0f;
    float rotationX = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 rotation = transform.localRotation.eulerAngles;
        rotation.y = -90;
        rotationY = rotation.y;
        rotationX = rotation.x;

    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        rotationX += - mouseY * mouseSensitivity * Time.deltaTime;
        rotationY += mouseX * mouseSensitivity * Time.deltaTime;
        rotationX = Mathf.Clamp(rotationX, lookupmin, lookupmax);
        rotationY = Mathf.Clamp(rotationY, lookleft, lookright);
        Quaternion localRotation = Quaternion.Euler(rotationX, rotationY, 0.0f);
        transform.rotation = localRotation;

    }
}
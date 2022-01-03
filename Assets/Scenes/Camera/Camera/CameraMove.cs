using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CameraMove : MonoBehaviour
{
    public float lookupmax = 80;
    public float lookupmin = -80;
    float mouseSensitivity = 200.0f;
   public float rotationY = 0.0f;
   public float rotationX = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 rotation = transform.localRotation.eulerAngles;
        rotationY = rotation.y;
        rotationX = rotation.x;

    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        if (GetComponent<Click_dialogue>().isTalking == false)
        {
            rotationY += mouseX * mouseSensitivity * Time.deltaTime;
            rotationX += mouseY * mouseSensitivity * Time.deltaTime;
            rotationX = Mathf.Clamp(rotationX, lookupmin, lookupmax);
            Quaternion localRotation = Quaternion.Euler(rotationX, rotationY, 0.0f);
            transform.rotation = localRotation;
        }
        if (GetComponent<Click_dialogue>().isTalking == true )
        {
            rotationY = rotationY;
            rotationX = rotationX;
        }

    }
}

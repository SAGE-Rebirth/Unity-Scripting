using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public PlayerController player;

    public float sensitivity = 200f, clamp = 40f;

    private float VerticalRotation, HorizontalRotation, MouseVertical, MouseHorizontal;
    // Start is called before the first frame update
    void Start()
    {
       VerticalRotation = transform.localEulerAngles.x;
       HorizontalRotation = transform.eulerAngles.y; 
    }

    // Update is called once per frame
    void Update()
    {
        MouseHorizontal = Input.GetAxis("Mouse X");
        MouseVertical = -Input.GetAxis("Mouse Y");

        VerticalRotation += MouseVertical * sensitivity * Time.deltaTime;
        HorizontalRotation += MouseHorizontal * sensitivity * Time.deltaTime;

        VerticalRotation = Mathf.Clamp(VerticalRotation, -clamp, clamp);

        transform.localRotation = Quaternion.Euler(VerticalRotation, 0f, 0f);
        player.transform.rotation = Quaternion.Euler(0f, HorizontalRotation, 0f);
    }
}

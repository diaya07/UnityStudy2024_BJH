using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    public float rotateSpeed = 200;


    // Update is called once per frame
    void Update()
    {
        RotatePlayer();
    }

    private void RotatePlayer()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float yow = horizontal * rotateSpeed * Time.deltaTime;
        transform.Rotate(Vector3.up, yow, Space.World);
    }
}

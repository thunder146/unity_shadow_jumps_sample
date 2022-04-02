using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCameraController : MonoBehaviour
{
    private Camera _camera;
    private Rigidbody _rb;
    public GameObject Ball;

    // Start is called before the first frame update
    void Start()
    {
        _camera = GetComponent<Camera>();

        _rb = Ball.GetComponent<Rigidbody>();
        _rb.AddForce(0, 0, 50, ForceMode.Impulse);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        _camera.transform.position = new Vector3(Ball.transform.position.x, Ball.transform.position.y + 1, Ball.transform.position.z - 5);
    }
}

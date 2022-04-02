using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallEnteredFloor : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ball")
        {
            var ball = other.gameObject;

            Debug.Log("Ball position: " + 
                "X: " + ball.transform.position.x +
                "Y: " + ball.transform.position.y +
                "Z: " + ball.transform.position.z);
        }
    }
}

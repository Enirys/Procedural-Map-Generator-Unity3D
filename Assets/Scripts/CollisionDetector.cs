using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour {

    public BallController ball;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Zaxis")
        {
            ball.turnZ = true;
            ball.turnX = false;
        }
        else if(other.gameObject.tag == "Xaxis")
        {
            ball.turnZ = false;
            ball.turnX = true;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CollisionDetector))]
[RequireComponent(typeof(Rigidbody))]
public class BallController : MonoBehaviour {

    public float moveSpeed;

    public bool turnX;
    public bool turnZ;

    private void Start()
    {
        turnX = true;
        turnZ = false;
    }

    // Update is called once per frame
    void Update ()
    {
        if(turnX)
        {
            moveX();
        }
        else if(turnZ)
        {
            moveZ();
        }
    }

    public void moveX()
    {
        transform.Translate(new Vector3(1, 0, 0) * moveSpeed * Time.deltaTime);
    }

    public void moveZ()
    {
        transform.Translate(new Vector3(0, 0, -1) * moveSpeed * Time.deltaTime);
    }
}

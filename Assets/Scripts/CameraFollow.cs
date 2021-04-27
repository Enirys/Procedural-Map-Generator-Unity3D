using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public Transform target;

    public float offsety;
    public float offsetx;
    public float offsetz;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        float offset = transform.position.y + offsety;
        transform.position = new Vector3(target.transform.position.x, offset, target.transform.position.z) ;
	}
}

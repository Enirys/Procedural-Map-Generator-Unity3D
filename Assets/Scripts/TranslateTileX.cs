using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslateTileX : MonoBehaviour {

    Vector3 offset;

	// Use this for initialization
	void Start ()
    {
        
        int rand = Random.Range(-2, 1) + 1;
        if(rand == 0)
        {
            rand = -1;
        }
        offset = new Vector3(rand, 0, 0);
        transform.position += offset;
    }
}

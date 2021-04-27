using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Destoy tile prefab after lifeTime*/

public class TileDestroy : MonoBehaviour {

    public float lifeTime;
	// Update is called once per frame
	void Update ()
    {
        Destroy(gameObject, lifeTime);
	}
}

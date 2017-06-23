using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StayHereScript : MonoBehaviour
{
    public Transform obj;
    public Vector3 pos;
    public Quaternion rot;

	// Use this for initialization
	void Start ()
    {
        pos = obj.position;
        rot = obj.rotation;        
	}
	
	// Update is called once per frame
	void Update ()
    {

        obj.position = pos;
        obj.rotation = rot;	
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class StayHereScript : NetworkBehaviour
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
        SetPos();
    }

    void SetPos()
    {
        obj.position = pos;
        obj.rotation = rot;
    }
}

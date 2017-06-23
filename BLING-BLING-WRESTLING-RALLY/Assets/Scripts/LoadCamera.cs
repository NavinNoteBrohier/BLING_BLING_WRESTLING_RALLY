using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadCamera : MonoBehaviour
{
    public Camera _Cam;

    // Use this for initialization
    void Start()
    {
        _Cam = GetComponentInChildren<Camera>();
        _Cam.transform.localPosition = new Vector3(1.372f, 1.305f, -1.194f);
        _Cam.transform.localRotation = Quaternion.Euler(new Vector3(0, -19.525f, 0));
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

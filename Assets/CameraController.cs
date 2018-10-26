using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Vector3 CameraOffset;
    [SerializeField] private Transform playerTransform;
	
	// Update is called once per frame
	void Update ()
	{
	    this.transform.position = playerTransform.position + CameraOffset;
	}
}

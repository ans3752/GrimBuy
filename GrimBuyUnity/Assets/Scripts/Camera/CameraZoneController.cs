using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoneController : MonoBehaviour
{
	public Camera Camera;

	private void OnTriggerEnter(Collider collision)
	{
	    if (collision.transform.name=="Player")
		{
			GameObject prevCam = GameObject.Find("Main Camera");
			prevCam.transform.name = "Camera";
			prevCam.gameObject.SetActive(false);
			Camera.transform.name = "Main Camera";
			Camera.tag = "MainCamera";
			Camera.gameObject.SetActive(true);
		}
	}
}

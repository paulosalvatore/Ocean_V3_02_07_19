using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlador : MonoBehaviour
{
	// Use this for initialization
	private void Start()
	{
	}

	// Update is called once per frame
	private void Update()
	{
		var controller = OVRInput.GetActiveController();

		if (Input.GetMouseButtonDown(0) || OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger, controller))
		{
		}
	}
}
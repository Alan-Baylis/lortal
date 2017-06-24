using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowPortal : MonoBehaviour
{

	public GameObject leftPortal;
	public GameObject rightPortal;
	private GameObject camera;
	private int i = 0;

	// Use this for initialization
	void Start ()
	{
		camera = GameObject.FindWithTag("MainCamera");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0))
		{
			throwPortal(leftPortal);
		}
		if (Input.GetMouseButtonDown(1))
		{
			throwPortal(rightPortal);
		}
		
	}

	private void throwPortal(GameObject portal)
	{
		i++;
		Debug.Log("elo");

		int x = Screen.width / 2;
		int y = Screen.height / 2;

		Ray ray = camera.GetComponent<Camera>().ScreenPointToRay(new Vector3(x, y));
		
		RaycastHit hit;
		if (Physics.Raycast(ray, out hit))
		{
			Quaternion objectRotation = Quaternion.LookRotation(hit.normal);
			portal.transform.position = hit.point;
			portal.transform.rotation = objectRotation;
		}

	}
}

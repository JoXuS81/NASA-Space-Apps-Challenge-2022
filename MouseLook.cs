using UnityEngine;
using System.Collections;

public class MouseLook : MonoBehaviour {
	
	public float mouseSensitivity = 150f;
	public Transform playerBody;

	// Use this for initialization
	void Start () {
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.Escape))
        {
			Cursor.lockState = CursorLockMode.None;
			Cursor.visible = true;
			mouseSensitivity = 0f;
		}
	}

	public void Resume()
    {
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
		mouseSensitivity = 150f;
	}

}
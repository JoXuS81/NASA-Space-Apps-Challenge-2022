﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Display : MonoBehaviour 
{

	public void Close()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 5);
	}

}
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class gPedia : MonoBehaviour 
{

	public void Close()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 5);
	}

}
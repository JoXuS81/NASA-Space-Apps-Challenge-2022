using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Startpoints : MonoBehaviour 
{

	public void Close()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
	}

	public void Controls()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 7);
	}

	public void khufuStartpoint()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 6);
	}

}
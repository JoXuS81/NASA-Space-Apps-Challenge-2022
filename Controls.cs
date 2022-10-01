using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Controls : MonoBehaviour 
{

	public void Close()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 7);
	}

}
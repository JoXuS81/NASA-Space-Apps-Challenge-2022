using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Timeline : MonoBehaviour 
{

	public void Close()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
	}

}
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Graphics : MonoBehaviour 
{

	public void Close()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 7);
	}

}
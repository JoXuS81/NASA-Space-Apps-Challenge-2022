using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour 
{

	public void Options()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 9);
	}

	public void Quit()
	{
		Application.Quit();
	}

}
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Options : MonoBehaviour 
{

	public void Display()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 5);
	}

	public void Graphics()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 7);
	}

	public void Menu()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 6);
	}

	public void Sound()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 8);
	}

}
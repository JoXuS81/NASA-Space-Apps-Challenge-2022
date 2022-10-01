using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class mainMenuBack : MonoBehaviour 
{

	public void Credits()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 4);
	}

	public void gPedia()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 5);
	}

	public void Options()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 6);
	}

	public void Quit() {
		Application.Quit();
	}

	public void Startpoints()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
	}

	public void Timeline()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
	}

}
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour 
{

	public void Credits()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
	}

	public void gPedia()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
	}

	public void Options()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}

	public void Quit() {
		Application.Quit();
	}

	public void Startpoints()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
	}

	public void Timeline()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 5);
	}

}
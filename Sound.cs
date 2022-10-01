using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sound : MonoBehaviour
{
	
	public void Close()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 8);
	}

}

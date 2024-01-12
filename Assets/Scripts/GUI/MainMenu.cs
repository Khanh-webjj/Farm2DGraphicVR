using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
	[SerializeField] string nameEssentialScene;
	[SerializeField] string nameNewGameStartScene;
	AsyncOperation operation;
    public void ExitGame()
	{
		Debug.LogError("Quit");
		Application.Quit(); // exit game
	}
	public void StartNewGame()
	{
        // load m�n h�nh sence kh�c nhau
        SceneManager.LoadScene(nameNewGameStartScene, LoadSceneMode.Single); //  m�n h�nh b?t ??u tr� ch?i
		SceneManager.LoadScene(nameEssentialScene,  LoadSceneMode.Additive); // thanh m�u v� n?ng l??ng 
		

	}
}

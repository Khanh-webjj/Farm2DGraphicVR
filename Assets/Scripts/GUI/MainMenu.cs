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
        // load màn hình sence khác nhau
        SceneManager.LoadScene(nameNewGameStartScene, LoadSceneMode.Single); //  màn hình b?t ??u trò ch?i
		SceneManager.LoadScene(nameEssentialScene,  LoadSceneMode.Additive); // thanh máu và n?ng l??ng 
		

	}
}

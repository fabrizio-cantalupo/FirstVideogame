using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{

    public void SelectLevel()
    {
        SceneManager.LoadScene("SelectLevel");
    }

    public void Options()
    {
        SceneManager.LoadScene("Options");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void NextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void BackScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void ExitGame()
    {
        Debug.Log("Exiting game");
        Application.Quit();
    }
}

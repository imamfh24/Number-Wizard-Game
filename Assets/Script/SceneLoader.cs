using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    public void loadStartScene()
    {
        //SceneManager.LoadScene(dalam ini) bisa berupa index ataupun nama dari scene
        SceneManager.LoadScene(0);
    }

    public void loadNextScene()
    {
        // Variabel ini digunakan untuk menampung index yang mana saat ini scene yang sedang aktif/dibuka/sedang dimainkan
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void loadPreviousScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex - 1);
    }

    public void exitGame()
    {
        Application.Quit();
    }
}

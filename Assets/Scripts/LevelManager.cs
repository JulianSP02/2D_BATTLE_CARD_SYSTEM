using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    [SerializeField]
    bool circularNavigation = true;

    /// <summary>
    ///  Returns Current Scene Index.
    /// </summary>
    /// <returns>Current Scene Indez.</returns>

    public int GetCurrentScene()
    {
        return SceneManager.GetActiveScene().buildIndex;
    }

    public int GetLastScene()
    {
        return SceneManager.sceneCountInBuildSettings - 1;
    }

    /// <summary>
    /// Navigates to First Scene
    /// </summary>
    public void FirstScene()
    {
        SceneManager.LoadScene(0);
    }

    /// <summary>
    /// Navigates to Last Scene
    /// </summary>
    public void LastScene()
    {
        SceneManager.LoadScene(GetLastScene());
    }

    /// <summary>
    /// Navigates to Next Scene from Current Scene.
    /// </summary>
    public void NextScene()
    {
        int currentScene = GetCurrentScene();    //Almacena el valor del indice de la ESCENA ACTUAL
        int lastScene = GetLastScene();          //Almacena el valor del indice de la ULTIMA ESCENA

        if (currentScene < lastScene)            //Si la escena actual NO ES LA ULTIMA escena
        {
            SceneManager.LoadScene(currentScene + 1);
        }

        else if (circularNavigation)
        {
            FirstScene();
        }
    }

    /// <summary>
    /// Navigates to Previous Scene from Current Scene.
    /// </summary>
    public void PreviousScene()
    {
        int currentScene = GetCurrentScene();

        if (currentScene > 0)
        {
            SceneManager.LoadScene(currentScene - 1);
        }
    }
}

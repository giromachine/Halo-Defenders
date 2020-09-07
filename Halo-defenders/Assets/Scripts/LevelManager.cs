using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    int currentSceneIndex;

    private void Start()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if(currentSceneIndex == 0)
        {
            LoadMainMenu();
        }
    }

    public void LoadMainMenu()
    {
        StartCoroutine(SplashSceneDelay());

    }
    IEnumerator SplashSceneDelay()
    {

        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene("MainMenu");

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuCanvas : MonoBehaviour
{
    public void StartGame()
    {
        int nextScene = SceneManager.GetActiveScene().buildIndex + 1;
        SceneManager.LoadScene(nextScene);
    }
}

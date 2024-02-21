using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayScene : MonoBehaviour
{
    public void GameScene()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1.0f;
    }

    public void toMenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1.0f;
    }

    public void playAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1.0f;
    }


}

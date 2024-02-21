using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pausePanel;

    public void Paused()
    {
        pausePanel.SetActive(true);
        Time.timeScale = 0;
    }

    public void Resume()
    {
        pausePanel.SetActive(false);
        Time.timeScale = 1;

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PausePanel : MonoBehaviour
{

    public GameObject pausePanel;
    // Start is called before the first frame update
    public void Pause()
    {
        Time.timeScale = 0.0f;
        pausePanel.SetActive(true);
    }
    public void Resume()
    {
        Time.timeScale = 1.0f;
        pausePanel.SetActive(false);
    }

    public void Restart()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Menu()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("MainMenu");
    }
}

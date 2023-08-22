using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseController : MonoBehaviour
{
    [SerializeField]
    GameObject pausePanel;

    [SerializeField]
    GameObject settingPanel;

   
    public void Pause()
    {
        pausePanel.SetActive(true);
        settingPanel.SetActive(false);
        Time.timeScale = 1.0F;

    }

    public void Home()
    {
        Debug.Log("Welcome Scene");
    }

    public void Resume()
    {
        pausePanel.SetActive(false);
        settingPanel.SetActive(true);
        Time.timeScale = 1.0F;
    }

    public void Reload()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        Time.timeScale = 1.0F;
    }
}

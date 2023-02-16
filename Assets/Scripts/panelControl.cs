using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class panelControl : MonoBehaviour
{
    public GameObject pausePanel;
    public GameObject pauseButton;
    public GameObject winPanel;
    public AudioSource gameAudio;
    public GameObject gameOverPanel;

    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        pausePanel.SetActive(false);
        winPanel.SetActive(false);
        gameOverPanel.SetActive(false);

        pauseButton.SetActive(true);
        scoreText.text = "Score: " + enemyMovement.score.ToString();
    }

    public void PauseMenu()
    {
        Time.timeScale = 0;
        pausePanel.SetActive(true);
        pauseButton.SetActive(false);


    }

    public void ReplayScene1()
    {
        SceneManager.LoadScene("level1");
        enemyMovement.score = 0;
        Time.timeScale = 1;
    }

    public void ReplayScene2()
    {
        SceneManager.LoadScene("level2");
        enemyMovement.score = 0;
        Time.timeScale = 1;
    }

    public void ReplayScene3()
    {
        SceneManager.LoadScene("level3");
        enemyMovement.score = 0;
        Time.timeScale = 1;
    }

    public void ResumeMenu()
    {
        Time.timeScale = 1;
        pausePanel.SetActive(false);
        pauseButton.SetActive(true);


    }

    public void muteButton()
    {
        gameAudio.mute = true;
    }

    public void unmutebutton()
    {
        gameAudio.mute = false;
    }

    public void Replay()
    {
        SceneManager.LoadScene("level3");
        Time.timeScale = 1;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("mainMenu");
    }


    public void Exit()
    {
        Application.Quit();
    }


    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + enemyMovement.score.ToString();
    }
}

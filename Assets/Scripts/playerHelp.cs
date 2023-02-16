using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerHelp : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject menuPanel;
    public GameObject selectLevels;
    public GameObject gameOverPanel;
    public GameObject instructionPanel;




    void Start()
    {
        menuPanel.SetActive(true);
        selectLevels.SetActive(false);
        gameOverPanel.SetActive(false);
        instructionPanel.SetActive(false);


    }

    public void MainMenu()
    {
        menuPanel.SetActive(true);
        selectLevels.SetActive(false);
        gameOverPanel.SetActive(false);
        instructionPanel.SetActive(false);


    }



    public void StartGame()
    {
        SceneManager.LoadScene("level1");

    }

    public void Instructions()
    {
        instructionPanel.SetActive(true);
        menuPanel.SetActive(false);
    }

    public void ExitGame()
    {
        Debug.Log("exit");

    }

    public void LevelSelect()
    {
        menuPanel.SetActive(false);
        selectLevels.SetActive(true);
    }

    public void level1Select()
    {
        SceneManager.LoadScene("level1");
    }

    public void level2Select()
    {
        SceneManager.LoadScene("level2");
    }

    public void level3Select()
    {
        SceneManager.LoadScene("level3");
    }

    // Update is called once per frame
    void Update()
    {

    }
}

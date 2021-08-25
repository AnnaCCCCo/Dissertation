using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButtons : MonoBehaviour
{
    public GameObject helpsPanel;

    private void Start()
    {
        helpsPanel.SetActive(false);
    }

    public void startGame()
    {
        SceneManager.LoadScene(1);
    }

    public void quitGame()
    {
        Application.Quit();
    }

    public void Helps()
    {
        helpsPanel.SetActive(true);
    }

    public void Back()
    {
        helpsPanel.SetActive(false);
    }
}

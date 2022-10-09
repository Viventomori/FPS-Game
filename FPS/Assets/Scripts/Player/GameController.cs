using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public static GameController instance;

    private int delta = 0;
    [SerializeField] private Text countTxt;
    [SerializeField] private GameObject menu;
    [SerializeField] private GameObject menuCamera;
    private int enemyKillCount;

    private void Awake()
    {
        Time.timeScale = 1;
        if (instance == null)
            instance = this;
    }

    public void StartGame(int delta)
    {
        this.delta = delta;
        Time.timeScale = delta;
    }
    public void StopGame(int delta)
    {
        Time.timeScale = delta;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void EnemyKilled()
    {
        enemyKillCount++;
        countTxt.text = "Enemy Killed : " + enemyKillCount;
    }

    public void DeadPlayer()
    {
        menu.SetActive(true);
        menuCamera.SetActive(true);
    }
}
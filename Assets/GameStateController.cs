using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStateController : Singleton<GameStateController>
{
    public enum GameStates { InGame, Menu }
    public float Score { get { return score; } }
    private float score;
    private GameStates currentState = GameStates.InGame;
    public GameStates CurrentState { get { return currentState; } }


    void Start()
    {
        score = 0;
        currentState = GameStates.InGame;
        DontDestroyOnLoad(this);
    }
    void Update()
    {
        if (currentState == GameStates.InGame)
        {
            CheckForGameOver();
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
    public void StartGame()
    {
        currentState = GameStates.InGame;
    }
    void CheckForGameOver()
    {
        if (currentState == GameStates.InGame && OxygenController.Instance.Ammount < 0)
        {
            currentState = GameStates.Menu;
            SceneManager.LoadScene("GameOver");
        }

    }
    public void LoadMain()
    {
        currentState = GameStates.InGame;
        score = 0;
        SceneManager.LoadScene("Level");
    }
    public void InvokeWin(int score)
    {
        this.score = score;
        currentState = GameStates.Menu;
        SceneManager.LoadScene("Win");
    }
}

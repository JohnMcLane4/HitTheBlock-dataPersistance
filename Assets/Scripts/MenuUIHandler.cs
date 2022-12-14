using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

// Sets the script to be executed later than all default scripts
// This is helpful for UI, since other things may need to be initialized before setting the UI
[DefaultExecutionOrder(1000)]
public class MenuUIHandler : MonoBehaviour
{
    public TMP_InputField playerNameInput;
    public TextMeshProUGUI highScoreText;

    public void Start()
    {
        highScoreText.text = new string("Highscore: " + GameManager.Instance.playerNameWithHighscore + " - " + GameManager.Instance.highScore.ToString());
        //Debug.Log(GameManager.Instance.playerNameWithHighscore);
    }
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void Quit()
    {
        //Debug.Log(GameManager.Instance.playerNameWithHighscore);
        GameManager.Instance.SaveHighScore();
        GameManager.Instance.SaveHighScoreName();
        Application.Quit();
    }

    public void OnNameEntered()
    {
        GameManager.Instance.playerName = playerNameInput.text;
        //Debug.Log(playerNameInput.text);
    }
}

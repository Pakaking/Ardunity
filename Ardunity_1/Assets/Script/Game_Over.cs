using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Game_Over : MonoBehaviour {

    public GameObject gameOverScreen;
    public Text ResultUI;
    bool gameOver;

    void Start()
    {
        FindObjectOfType<Player_Controller>().OnPlayerDeath += OnGameOver;
    }

    void Update () {
        if(gameOver)
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene(0);
            }
        }
	}

    void OnGameOver()
    {
        gameOverScreen.SetActive(true);
        ResultUI.text = Mathf.RoundToInt(Time.timeSinceLevelLoad).ToString();
        gameOver = true;
    }
}

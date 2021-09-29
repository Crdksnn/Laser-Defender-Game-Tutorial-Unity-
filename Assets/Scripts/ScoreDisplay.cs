using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    Text scoreTextGameScreen;
    GameSession gameSession;

    void Start()
    {
        scoreTextGameScreen = GetComponent<Text>();
        gameSession = FindObjectOfType<GameSession>();
    }

    void Update()
    {
        scoreTextGameScreen.text = gameSession.GetScore().ToString();
    }
}

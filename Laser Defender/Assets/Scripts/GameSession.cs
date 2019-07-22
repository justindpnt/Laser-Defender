using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSession : MonoBehaviour {

    // Configuration Parameters
    int score = 0;

    // Call the Singleton upon awake
    private void Awake() {
        SetUpSingleton();
    }

    // Handles the Singleton structure to support the Game Session instance
    private void SetUpSingleton() {
        int numberGameSessions = FindObjectsOfType<GameSession>().Length;
        if(numberGameSessions > 1) {
            Destroy(gameObject);
        } else {
            DontDestroyOnLoad(gameObject);
        }
    }

    // Return the score value 
    public int GetScore() {
        return score;
    }

    // Add a given value to the score
    public void AddToScore(int scoreValue) {
        score += scoreValue;
    }

    // Destroy the current game session when the game ends to allow for the creation of a new instance
    public void ResetGame() {
        Destroy(gameObject);
    }
}

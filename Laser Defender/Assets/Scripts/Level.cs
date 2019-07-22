using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour {

    // Configuration Parameters
    [SerializeField] float delayInSeconds = 2f;

    // Load the Start Menu
    public void LoadStartMenu() {
        SceneManager.LoadScene(0);
    }

    // Load the main scene of the game
    public void LoadGame() {
        SceneManager.LoadScene("Game");
        FindObjectOfType<GameSession>().ResetGame();
    }

    // Load the game over screen after the player dies
    public void LoadGameOver() {
        StartCoroutine(WaitAndLoad());
    }

    // The process to start the game over
    IEnumerator WaitAndLoad() {
        yield return new WaitForSeconds(delayInSeconds);
        SceneManager.LoadScene("Game Over");
    }

    // Quit the game
    public void QuitGame() {
        Application.Quit();
    }
}

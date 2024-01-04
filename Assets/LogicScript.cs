using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    // Start is called before the first frame update
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverObject;

    [ContextMenu("Increase score")]
    public void addScore()
    {
        playerScore++;
        scoreText.text=playerScore.ToString();
    }

    

    public void showGameOverText()
    {
        gameOverObject.SetActive(true);
    }

    public void resetGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

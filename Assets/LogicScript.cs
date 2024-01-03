using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    // Start is called before the first frame update
    public int playerScore;
    public Text scoreText;

    [ContextMenu("Increase score")]
    public void addScore()
    {
        playerScore++;
        scoreText.text=playerScore.ToString();
    }
}

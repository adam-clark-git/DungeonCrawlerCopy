using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text score;
    public GameObject gameOverScreen;
    public NewBehaviourScript birdScript;
    public AudioSource blipSound;
    [ContextMenu("Increase Score")]
    public void AddScore(int scoreAdded)
    {
        
        if (birdScript.birdIsAlive)
        {
            playerScore += scoreAdded;
            score.text = playerScore.ToString();
            blipSound.Play();
        }
        
    }
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void GameOver()
    {
        gameOverScreen.SetActive(true);
    }
}

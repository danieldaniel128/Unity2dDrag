using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static int _maxHealth=5;
    public static int Health;
    public Text lives;
    public static Text livesCounter;
    private string _livesText;
    private void Awake()
    {
        if (SceneManager.GetActiveScene().buildIndex == 0)
        { 
        livesCounter = lives;
        _livesText = lives.text;
        Health = _maxHealth;
        lives.text = _livesText + Health.ToString();
        }
    }

    private void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex == 0)
            lives.text = livesCounter.text;
    }
    static public void GameOver()
    {
       SceneManager.LoadScene(1);
    }

    static public void PlayAgain()
    {
        DieOnHit.IsCollidingWall = false;
           Health = _maxHealth;
        SceneManager.LoadScene(0);
    }



}

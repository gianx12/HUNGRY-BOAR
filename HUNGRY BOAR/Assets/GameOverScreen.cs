using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    //public Text pointsText;
    public PlayfabManager playfabManager;

    public void Setup()
    {
        gameObject.SetActive(true);
        playfabManager.SendLeaderboard(ScoreText.instance.GetScore());
        //pointsText.text = score.ToString() + " MONNEZZA";
    }

    public void RestartButton()
    {
        SceneManager.LoadScene("LivelloUno");
    }

    public void ExitButton()
    {
        SceneManager.LoadScene("Start Menu");
    }
}

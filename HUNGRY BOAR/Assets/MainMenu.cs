using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("LivelloUno");
    }

    public void SwitchToLeaderboard()
    {
        SceneManager.LoadScene("Leaderboard");
    }

    public void SwitchToLogin()
    {
        SceneManager.LoadScene("Login");
    }

    public void SwitchToMainMenu()
    {
        SceneManager.LoadScene("Start Menu");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private GameObject _settingsPanel;
    public void PlayGame()
    {
        Application.LoadLevel("Game");
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void SettigsPanel()
    {
        _settingsPanel.SetActive(true);
    }

    public void ExitSettingsPanel()
    {
        _settingsPanel.SetActive(false);
    }

    public void ExitToMenu()
    {
        Application.LoadLevel("Menu");
        TopScore.SaveTopScore(ScoreCounter.HighRuntimeScore);
    }
}

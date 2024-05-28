using TMPro;
using UnityEngine;

public class TopScore : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _scoreTop;

    private void Awake()
    {
        _scoreTop.text =LoadTopScore().ToString();
    }

    public static int LoadTopScore()
    {
        if (PlayerPrefs.HasKey("HighScore")) return PlayerPrefs.GetInt("HighScore");
        return 0;
    }

    public static void SaveTopScore(int score)
    {
        if(score > LoadTopScore())
        {
            score = Mathf.FloorToInt(ScoreCounter.HighRuntimeScore);
            PlayerPrefs.SetInt("HighScore", score);
        }
    }
}
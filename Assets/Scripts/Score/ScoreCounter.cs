using UnityEngine;
using TMPro;

public class ScoreCounter : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _scoreGT;
    public static int HighRuntimeScore;
    private int _runtimeScore;
    private void Start()
    {
        GameObject scoreGO = GameObject.Find("TextScoreCounter");
        _scoreGT = scoreGO.GetComponent<TextMeshProUGUI>();
        HighRuntimeScore = 0;
    }

    private void Update()
    {
        UpdateScore();
        UpdateScoreText();
    }

    private void UpdateScore()
    {
        _runtimeScore = Mathf.FloorToInt(transform.position.y);
        if (_runtimeScore > HighRuntimeScore)
        {
            HighRuntimeScore = _runtimeScore;
        }
    }
    private void UpdateScoreText()
    {
        _scoreGT.text = Mathf.FloorToInt(HighRuntimeScore).ToString();
    }
}

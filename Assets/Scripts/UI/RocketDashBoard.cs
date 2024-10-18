using TMPro;
using UnityEngine;

public class RocketDashBoard : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI currenScoreTxt;
    [SerializeField] private TextMeshProUGUI highScoreTxt;

    private float zeroPoint;
    private float rocketHeight;

    private string score;
    private string highScore;

    private string highScoreKey = "HighScoreKey";

    private void Start()
    {
        zeroPoint = transform.position.y;
        score = "0";
        if(PlayerPrefs.HasKey(highScoreKey))
        {
            highScore = PlayerPrefs.GetString(highScoreKey);
            highScoreTxt.text = WriteScore(highScore, "HIGH : ");
        }
        else
        {
            highScore = "0";
        }
    }

    private void Update()
    {
        CheckScore();
    }

    private void CheckScore()
    {
        rocketHeight = (transform.position.y - zeroPoint) * 100;
        score = rocketHeight.ToString("N0");
        currenScoreTxt.text = WriteScore(score, "");
        if (rocketHeight > float.Parse(highScore))
        {
            highScore = score;
            PlayerPrefs.SetString(highScoreKey, highScore);
            highScoreTxt.text = WriteScore(highScore, "HIGH : ");
        }
    }

    private string WriteScore(string score, string scoreType)
    {
        score = $"{scoreType}{score} M";
        return score;
    }
}
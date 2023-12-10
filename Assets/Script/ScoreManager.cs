// ScoreManager.cs
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private int score = 0;

    // 引用 MainMenuController 的字段
    public MainMenuController mainMenuController;

    void Start()
    {
        UpdateScoreUI();
    }

    public void AddScore(int points)
    {
        score += points;
        UpdateScoreUI();

        // 在得到40分时调用显示开始界面的方法
        if (score >= 40 && mainMenuController != null)
        {
            mainMenuController.ShowStartPanel();
        }
    }

    void UpdateScoreUI()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score;
        }
    }
}

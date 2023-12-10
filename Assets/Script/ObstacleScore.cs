using UnityEngine;

public class ObstacleScore : MonoBehaviour
{
    // 引用 ScoreManager 的字段
    public ScoreManager scoreManager;

    // 在障碍物被销毁时调用
    void OnDestroy()
    {
        if (scoreManager != null)
        {
            // 通知 ScoreManager 加分
            scoreManager.AddScore(10);
        }
    }
}

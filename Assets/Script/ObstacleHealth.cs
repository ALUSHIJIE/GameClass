// ObstacleHealth.cs
using UnityEngine;

public class ObstacleHealth : MonoBehaviour
{
    public int maxHealth = 100;
    private int currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;

        // 在这里可以添加其他处理，例如受伤的动画等

        // 如果生命值小于等于0，销毁障碍物
        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }

    // 添加获取当前生命值的方法
    public int GetCurrentHealth()
    {
        return currentHealth;
    }
}

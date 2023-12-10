using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    private int currentHealth;

    public Image healthBar; // 添加 Image 用于显示血条

    public int CurrentHealth
    {
        get { return currentHealth; }
    }

    private void Start()
    {
        currentHealth = maxHealth;
        UpdateHealthBar();
    }

    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;

        // 如果血量小于等于0，执行玩家死亡逻辑
        if (currentHealth <= 0)
        {
            Die();
        }

        UpdateHealthBar();
    }

    private void Die()
    {
        // 此处可以添加其他玩家死亡逻辑
        Debug.Log("Player has died");
        // 销毁玩家对象
        Destroy(gameObject);
    }

    private void UpdateHealthBar()
    {
        // 如果有关联的血条对象
        if (healthBar != null)
        {
            // 更新血条的 fillAmount 属性
            healthBar.fillAmount = (float)currentHealth / maxHealth;
        }
    }
}

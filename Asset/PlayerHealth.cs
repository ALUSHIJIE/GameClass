using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    private int currentHealth;

    public int CurrentHealth
    {
        get { return currentHealth; }
    }

    private void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;

        // 如果血量小于等于0，执行玩家死亡逻辑
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        // 此处可以添加其他玩家死亡逻辑
        Debug.Log("Player has died");
        // 销毁玩家对象
        Destroy(gameObject);
    }
}

using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public int damageAmount = 10; 
    public float attackCooldown = 2f; 
    private float timeSinceLastAttack = 0f;

    private void Update()
    {
        if (Time.time - timeSinceLastAttack >= attackCooldown)
        {
            AttackPlayer();
            timeSinceLastAttack = Time.time;
        }
    }

    private void AttackPlayer()
    {
    
        GameObject player = GameObject.FindGameObjectWithTag("Player");

        if (player != null)
        {
            PlayerHealth playerHealth = player.GetComponent<PlayerHealth>();

            if (playerHealth != null)
            {
                playerHealth.TakeDamage(damageAmount);
                Debug.Log("Player attacked! Player's current health: " + playerHealth.CurrentHealth);
            }
        }
    }
}

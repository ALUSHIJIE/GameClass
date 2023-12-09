using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject explosionEffectPrefab; // 指定 Particle System 预制体

    void Die()
    {
        // 实例化并播放 Particle System 特效
        Instantiate(explosionEffectPrefab, transform.position, Quaternion.identity);

        // 销毁敌人对象
        Destroy(gameObject);
    }
}

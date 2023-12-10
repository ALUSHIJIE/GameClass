// PlayerShoot.cs
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject redBallPrefab; // 引用红色小球预制体
    private GameObject currentRedBall; // 用于存储当前的红色小球
    public float shootSpeed = 10f; // 小球的发射速度
    public int damageAmount = 10;

    void Update()
    {
        // 鼠标左键按住检测
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }

        if (currentRedBall != null)
        {
            // 获取玩家的移动方向
            Vector3 playerDirection = transform.forward;

            // 使用移动方向移动小球
            currentRedBall.transform.Translate(playerDirection * shootSpeed * Time.deltaTime);
        }
    }

    void Shoot()
    {
        // 创建红色小球
        GameObject redBall = Instantiate(redBallPrefab, transform.position, Quaternion.identity);

        Vector3 playerForward = transform.position;

        // 将小球的朝向设置为玩家的朝向
        redBall.transform.position = playerForward;
        // 在这里可以添加其他处理，例如音效等

        // 将当前红色小球设置为新创建的小球
        currentRedBall = redBall;

        // 销毁小球，防止它无限制地飞行
        Destroy(redBall, 2f);
    }

    // 处理碰撞
    void OnCollisionEnter(Collision collision)
    {
        {
            Debug.Log("Collision occurred with: " + collision.gameObject.name);
            // 其他逻辑...
        }
        // 获取碰撞到的游戏对象
        GameObject hitObject = collision.gameObject;

        // 判断碰撞对象是否为障碍物
        if (hitObject.CompareTag("Obstacle"))
        {
            // 获取障碍物的生命值组件
            ObstacleHealth obstacleHealth = hitObject.GetComponent<ObstacleHealth>();

            // 判断生命值组件是否存在
            if (obstacleHealth != null)
            {
                // 使障碍物掉血
                obstacleHealth.TakeDamage(damageAmount);

                // 获取障碍物的当前生命值
                int currentHealth = obstacleHealth.GetCurrentHealth();
                Debug.Log("Obstacle Current Health: " + currentHealth);

                // 检查障碍物的生命值，如果小于等于0，则销毁障碍物
                if (currentHealth <= 0)
                {
                    Destroy(hitObject);
                }
            }

            // 销毁小球
            Destroy(currentRedBall);
        }
    }
}

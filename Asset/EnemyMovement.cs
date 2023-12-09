using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float movementSpeed = 5f;
    private Transform player; // 玩家控制的物体的Transform

    void Start()
    {
        // 获取玩家控制的物体的Transform
        player = GameObject.FindGameObjectWithTag("Player").transform;

        // 如果你的玩家对象有一个特定的标签，请将 "Player" 替换为你的玩家标签
    }

    void Update()
    {
        // 判断玩家是否存在
        if (player != null)
        {
            // 计算朝向玩家的方向
            Vector3 direction = (player.position - transform.position).normalized;

            // 通过LookRotation计算旋转，并使用Slerp平滑旋转
            Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
            transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5f);

            // 移动向前（沿着z轴正方向）
            transform.Translate(Vector3.forward * movementSpeed * Time.deltaTime);
        }
    }
}

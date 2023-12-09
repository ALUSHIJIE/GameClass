using UnityEngine;

public class RandomMovement : MonoBehaviour
{
    public float moveSpeed = 5.0f; // 移动速度
    public float changeDirectionInterval = 2.0f; // 改变方向的时间间隔
    private Vector3 moveDirection; // 移动方向
    private float timer; // 计时器

    void Start()
    {
        // 初始化移动方向
        ChangeDirection();
    }

    void Update()
    {
        // 更新计时器
        timer += Time.deltaTime;

        // 如果计时器超过时间间隔，改变移动方向
        if (timer >= changeDirectionInterval)
        {
            ChangeDirection();
            timer = 0f; // 重置计时器
        }

        // 计算模型的移动量
        Vector3 movement = moveDirection.normalized * moveSpeed * Time.deltaTime;

        // 更新模型的位置
        transform.Translate(movement);
    }

    void ChangeDirection()
    {
        // 随机选择一个新的移动方向
        moveDirection = new Vector3(Random.Range(-1f, 1f), 0f, Random.Range(-1f, 1f)).normalized;
    }
}

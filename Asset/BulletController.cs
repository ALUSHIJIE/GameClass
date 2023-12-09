using UnityEngine;

public class BulletController : MonoBehaviour
{
    private float bulletSpeed; // 子弹速度
    private float maxDistance; // 子弹的最大飞行距离
    private float traveledDistance; // 已飞行距离

    public void Initialize(float speed, float maxDist)
    {
        bulletSpeed = speed;
        maxDistance = maxDist;
        traveledDistance = 0.0f;
    }

    private void Update()
    {
        // 计算子弹的移动
        float moveDistance = bulletSpeed * Time.deltaTime;
        traveledDistance += moveDistance;

        // 将子弹前进
        transform.Translate(Vector3.forward * moveDistance);

        // 检查子弹是否达到最大飞行距离，如果是，则销毁子弹
        if (traveledDistance >= maxDistance)
        {
            Destroy(gameObject);
        }
    }
}

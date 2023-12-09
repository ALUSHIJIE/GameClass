using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5.0f; // 移动速度
    public GameObject bulletPrefab; // 子弹预制体
    public Transform bulletSpawnPoint; // 子弹生成点
    public float bulletSpeed = 10.0f; // 子弹速度
    public float maxBulletDistance = 10.0f; // 子弹的最大飞行距离

    private void Update()
    {
        // 角色移动
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 moveDirection = new Vector3(horizontalInput, 0, verticalInput).normalized;
        Vector3 move = transform.TransformDirection(moveDirection) * moveSpeed * Time.deltaTime;
        transform.position += move;

        // 鼠标发射子弹
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        // 创建子弹
        GameObject bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);

        // 添加子弹控制脚本
        BulletController bulletController = bullet.AddComponent<BulletController>();
        bulletController.Initialize(bulletSpeed, maxBulletDistance);

        // 注意：在不再需要时销毁子弹以防止内存泄漏
        Destroy(bullet, maxBulletDistance / bulletSpeed);
    }
}

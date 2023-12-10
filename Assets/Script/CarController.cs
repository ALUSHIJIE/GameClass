using UnityEngine;

public class CarController : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float turnSpeed = 100f;

    private void Update()
    {
        // 获取玩家输入
        float horizontalInput = Input.GetAxis("Horizontal"); // A 和 D键或左右箭头键
        float verticalInput = Input.GetAxis("Vertical");     // W 和 S键或上下箭头键

        // 计算汽车的前进和后退
        float moveAmount = verticalInput * moveSpeed * Time.deltaTime;

        // 计算汽车的左右转向
        float turnAmount = horizontalInput * turnSpeed * Time.deltaTime;

        // 应用移动和旋转
        // 使用 Transform.TransformDirection 将移动和旋转应用于相对于当前方向的本地坐标系
        transform.Translate(Vector3.forward * moveAmount, Space.Self);
        transform.Rotate(Vector3.up * turnAmount, Space.Self);
    }
}

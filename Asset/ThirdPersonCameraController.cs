using UnityEngine;

public class ThirdPersonCameraController : MonoBehaviour
{
    public Transform target; // 要跟随的目标，即人物模型
    public float distance = 5.0f; // 相机距离目标的距离
    public float height = 2.0f; // 相机相对目标的高度
    public float rotationSpeed = 1.0f; // 相机旋转速度

    private float currentRotationAngle = 0.0f;

    void LateUpdate()
    {
        if (target != null)
        {
            // 计算目标的旋转角度
            float wantedRotationAngle = target.eulerAngles.y;
            float currentRotationAngle = transform.eulerAngles.y;

            // 平滑插值旋转角度
            currentRotationAngle = Mathf.LerpAngle(currentRotationAngle, wantedRotationAngle, rotationSpeed * Time.deltaTime);

            // 计算相机的旋转
            Quaternion currentRotation = Quaternion.Euler(0, currentRotationAngle, 0);

            // 计算相机的目标位置
            Vector3 targetPosition = target.position - (currentRotation * Vector3.forward * distance);
            targetPosition.y = target.position.y + height;

            // 设置相机位置和旋转
            transform.position = targetPosition;
            transform.LookAt(target);
        }
    }
}

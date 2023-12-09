using UnityEngine;

public class AIController : MonoBehaviour
{
    public float moveSpeed = 3.0f; // 移动速度
    public Vector3 moveDirection = new Vector3(1, 0, 0); // 移动方向

    void Update()
    {
        // 移动AI角色
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
    }
}

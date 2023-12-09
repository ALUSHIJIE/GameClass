using UnityEngine;

public class FollowCar : MonoBehaviour
{
    public Transform target; // 将模型车的Transform组件拖放到这里
    public Vector3 offset = new Vector3(0f, 5f, -10f); // 相机相对于模型车的偏移

    private void Update()
    {
        if (target != null)
        {
            // 让相机跟随模型车移动
            transform.position = target.position + offset;
            transform.LookAt(target);
        }
    }
}

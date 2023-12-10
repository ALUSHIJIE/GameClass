using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        // 检测碰撞对象是否有一个Rigidbody组件（表示它是一个可碰撞的物体）
        if (collision.gameObject.GetComponent<Rigidbody>() != null)
        {
            // 销毁碰撞的物体
            Destroy(collision.gameObject);
        }

        // 然后销毁小球本身
        Destroy(gameObject);
    }
}

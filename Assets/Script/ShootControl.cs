using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootController : MonoBehaviour
{
    public GameObject redBallPrefab; // 引用红色小球预制体
    private GameObject currentRedBall; // 用于存储当前的红色小球
    public float shootSpeed = 40f; // 小球的发射速度

    void Update()
    {
        // 检测鼠标左键点击
        if (Input.GetMouseButtonDown(0))
        {
            // 销毁当前的红色小球（如果存在）
            Destroy(currentRedBall);
            // 创建新的红色小球并发射
            currentRedBall = InstantiateRedBall();

        }

        // 更新红色小球的位置
        if (currentRedBall != null)
        {
            Vector3 newPosition = currentRedBall.transform.position + currentRedBall.transform.forward * shootSpeed * Time.deltaTime;
            currentRedBall.transform.position = newPosition;
        }
    }

    GameObject InstantiateRedBall()
    {
        // 实例化红色小球，并设置其位置为模型位置
        GameObject redBall = Instantiate(redBallPrefab, transform.position, transform.rotation);
        // 将小球的颜色设置为红色
        redBall.GetComponent<Renderer>().material.color = Color.red;

        // 获取小球的刚体组件
        Rigidbody rb = redBall.GetComponent<Rigidbody>();
        if (rb != null) // 移除刚体组件，不再受物理引擎影响
        {
            Destroy(rb);
        }

        return redBall;
    }
}

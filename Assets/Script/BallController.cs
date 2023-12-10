using UnityEngine;

public class BallController : MonoBehaviour
{
    private bool isGrabbing = false;
    private Rigidbody rb;
    private Transform grabbedObject;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.isKinematic = true; // 刚体初始时设置为运动学，防止刚体受力
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (!isGrabbing)
            {
                // 尝试抓取物体
                TryGrabObject();
            }
            else
            {
                // 释放抓取的物体
                ReleaseObject();
            }
        }
    }

    void TryGrabObject()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.CompareTag("GrabableObject"))
            {
                grabbedObject = hit.collider.transform;
                isGrabbing = true;

                // 解除运动学，以允许物理模拟
                rb.isKinematic = false;
                rb.velocity = Vector3.zero;
                rb.angularVelocity = Vector3.zero;
            }
        }
    }

    void ReleaseObject()
    {
        if (grabbedObject != null)
        {
            // 恢复运动学，停止球的物理模拟
            rb.isKinematic = true;
            isGrabbing = false;
            grabbedObject = null;
        }
    }
}

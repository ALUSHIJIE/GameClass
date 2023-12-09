using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveModel : MonoBehaviour
{
    public float moveSpeed = 5.0f; 
    public Vector3 moveDirection = Vector3.forward; 

    void Update()
    {

        Vector3 movement = moveDirection.normalized * moveSpeed * Time.deltaTime;


        transform.Translate(movement);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public int speed = 10;

    public float moveDirection = 0f;

    private void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.position += Vector3.left * this.speed * Time.deltaTime;
            moveDirection = Input.GetAxisRaw("Horizontal");
        }
        else if (Input.GetKey(KeyCode.D))
        {
            this.transform.position += Vector3.right * this.speed * Time.deltaTime;
            moveDirection = Input.GetAxisRaw("Horizontal");
        }
        else
        {
            moveDirection = 0f;
        }
    }
}
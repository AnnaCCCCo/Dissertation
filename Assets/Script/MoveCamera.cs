using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    private float moveSpeed = 8.0f;
    private float xm = 0, ym = 9.5f, zm = -10.5f;

    void Update()
    {
        this.GetComponent<Transform>().position = new Vector3(xm, ym, zm);
    }

    private void FixedUpdate()
    {
        MoveC();
    }

    void MoveC()
    {
        if (xm > -20 && xm < 40 && zm > -22 && zm < 9)
        {
            if (Input.GetKey(KeyCode.A))
            {
                xm -= moveSpeed * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.D))
            {
                xm += moveSpeed * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.W))
            {
                zm += (float)(moveSpeed / 1.414) * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.S))
            {
                zm -= (float)(moveSpeed / 1.414) * Time.deltaTime;
            }
        }
        if (xm < -20) xm = -19.9f;
        if (xm > 40) xm = 39.9f;
        if (zm < -22) zm = -21.9f;
        if (zm > 9) zm = 8.9f;
    }
}

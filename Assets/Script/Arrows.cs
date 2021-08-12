using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Arrows : MonoBehaviour
{
    private GameObject MainCamera;
    private Vector2 FrontVector;
    private Vector2 ToCameraVector;

    void Start()
    {
        MainCamera = GameObject.Find("Main Camera");
        FrontVector = new Vector2(0, -1);
    }

    void Update()
    {
        if (transform.position.y <= 2.5f)
            transform.DOMoveY(3.5f, 0.5f);
        if (transform.position.y >= 3.5f)
            transform.DOMoveY(2.5f, 0.5f);

        ToCameraVector = new Vector2(MainCamera.transform.position.x - transform.position.x,
            MainCamera.transform.position.z - transform.position.z);
        float angle = Vector2.Angle(FrontVector, ToCameraVector);
        float deltaX = MainCamera.transform.position.x - transform.position.x;
        if (deltaX > 0)
            angle *= -1;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.up);
    }
}

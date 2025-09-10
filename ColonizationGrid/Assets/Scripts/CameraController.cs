using System;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Camera cam;

    [SerializeField] private float xInput;
    [SerializeField] private float yInput;
    [SerializeField] private int moveSpeed = 20;

    public static CameraController instance;

    private void Awake()
    {
        instance = this;
        cam = Camera.main;
    }

    private void MoveByKB()
    {
        xInput = Input.GetAxis("Horizontal");
        yInput = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(xInput, yInput, 0f);
        var deltaTime = Time.deltaTime;
        transform.position += dir * (moveSpeed * deltaTime);
    }

    private void Update()
    {
        MoveByKB();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class CameraControll : MonoBehaviour
{
    public Transform player;
    private Vector3 offset = new Vector3(0, 1, -4);
    public float rotationSpeed = 5.0f;

    void Start()
    {
        
    }

    void LateUpdate()
    {
        Quaternion playerRotation = player.rotation;
        Vector3 desiredPosition = player.position + playerRotation * offset;
        transform.position = Vector3.Lerp(transform.position, desiredPosition, rotationSpeed * Time.deltaTime);
        transform.LookAt(player);

    }
}

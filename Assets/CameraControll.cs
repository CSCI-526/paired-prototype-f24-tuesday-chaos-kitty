using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class CameraControll : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 1, -4);


    void Start()
    {
        
    }

    void LateUpdate()
    {

        transform.position = player.transform.position + offset;

    }
}

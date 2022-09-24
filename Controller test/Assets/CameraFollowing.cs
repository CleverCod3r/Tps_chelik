using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowing : MonoBehaviour
{
    public Transform target;
    public float cameraSpeed = 15;
    public float xOffset = 22;
    public float zOffset = 22;
    public bool smoothFollow = true;

    // Update is called once per frame
    void Update()
    {
        if (target)
        {
            Vector3 newPos = transform.position;
            newPos.x = target.position.x - xOffset;
            newPos.z = target.position.z - zOffset;

            if (!smoothFollow) transform.position = newPos;
            else transform.position = Vector3.Lerp(transform.position, newPos, cameraSpeed * Time.deltaTime);
        }
    }
}

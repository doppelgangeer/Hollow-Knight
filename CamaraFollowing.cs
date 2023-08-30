using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraFollowing : MonoBehaviour
{
    public GameObject CameraHollow;
    // Update is called once per frame
    void Update()
    {
        Vector3 position = transform.position;
        position.x = CameraHollow.transform.position.x;
        position.y = CameraHollow.transform.position.y;
        transform.position = position;
    }
}

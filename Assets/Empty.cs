using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Empty : MonoBehaviour
{

    public float y;

    void Update()
    {
        Transform transform = GetComponent<Transform>();
        Vector3 angle = new Vector3(0, y * Time.deltaTime, 0);
        transform.Rotate(angle);
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Earth : MonoBehaviour {

    // Use this for initialization
    public float y;

	void Update ()
    {
        /*
        Vector4 vector = new Vector4(-1.0f, 0.0f, 0.0f);
        Transform transform = GetComponent<Transform>();
        Vector4 angle = new Vector4(0, y, 0);
        transform.Rotate(angle);
        */
        Transform transform = GetComponent<Transform>();
        Vector3 angle = new Vector3(0, y* Time.deltaTime, 0);
        transform.Rotate(angle);

    }
}

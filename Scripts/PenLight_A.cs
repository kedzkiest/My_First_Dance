using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PenLight_A : MonoBehaviour
{
    float t = 0;
    float x, y, z;
    public GameObject penLight;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 tmp = penLight.transform.position;
        x = tmp.x;
        y = tmp.y;
        z = tmp.z;
    }

    // Update is called once per frame
    void Update()
    {
        t += 0.1f;
        transform.Rotate(0, 0, 9 * Mathf.Sin(1.5f * t));
        transform.position = new Vector3(x + Mathf.Cos(1.5f * t), y, z);

    }
}

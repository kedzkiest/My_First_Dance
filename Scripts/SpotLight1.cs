using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpotLight1 : MonoBehaviour
{
    float t = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t += 0.1f;
        transform.Rotate(0, 4, 0, Space.World);
        transform.position = new Vector3(-10 + 5 * Mathf.Cos(t/2), 20, 5 + 5 * Mathf.Sin(t/2));
    }
}

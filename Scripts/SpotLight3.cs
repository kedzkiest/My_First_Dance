using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpotLight3 : MonoBehaviour
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
        transform.Rotate(0, -4, 0, Space.World);
        transform.position = new Vector3(-5 + 4 * Mathf.Sin(t/2), 20, -5 + 4 * -Mathf.Sin(t));
    }
}

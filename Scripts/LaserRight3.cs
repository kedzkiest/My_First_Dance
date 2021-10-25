using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserRight3 : MonoBehaviour
{
    public LineRenderer l;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        l.positionCount = 2;

        l.SetPosition(0, new Vector3(15, 23, 18));
        l.SetPosition(1, new Vector3(-35, 5 + Mathf.PingPong(Time.time*3, 15), -20));

        l.startWidth = 0.05f;
        l.endWidth = 0.05f;

        l.useWorldSpace = true;
    }
}

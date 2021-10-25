using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightBlink_a : MonoBehaviour
{
    public Material myMat;
    float t = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t += 0.1f;
        float val = Mathf.Abs(Mathf.Sin(t));
        Color color = new Color(val, val, val, val);
        myMat.color = color;
        myMat.SetColor("_EmissionColor", color);
    }
}

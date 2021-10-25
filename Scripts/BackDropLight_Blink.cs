using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackDropLight_Blink : MonoBehaviour
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
        float val = Mathf.Sin(t);
        Color color = new Color(0f, val, 0f);
        myMat.color = color;
        myMat.SetColor("_EmissionColor", color);
    }
}

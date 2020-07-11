using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using InteractML;

public class AlertVelocity : MonoBehaviour
{

    public Light light;

    [PullFromIMLController]
    public int SetLightColor;

    // Start is called before the first frame update
    void Start()
    {
        light.color = Color.green;
    }

    // Update is called once per frame
    void Update()
    {
        if (SetLightColor == 1)
        {
            print(SetLightColor);
            light.color = Color.red;
        }
    }
}

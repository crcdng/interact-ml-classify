using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using InteractML;

public class AlertVelocity : MonoBehaviour
{

    public Light light;

    [PullFromIMLController]
    public int SetLightColor;
    private int PreviousLightColor = -1;

    // Start is called before the first frame update
    void Start()
    {
        light.color = Color.green;
    }

    // Update is called once per frame
    void Update()
    {
        if (SetLightColor == PreviousLightColor) { return; }
        if (SetLightColor == 1)
        {
            light.color = Color.red;
        } else if (SetLightColor == 0)
        {
            light.color = Color.green;
        }
        PreviousLightColor = SetLightColor;
    }
}

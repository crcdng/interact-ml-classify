using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using InteractML;

public class AlertVelocity : MonoBehaviour
{

    public Light light;

    [PullFromIMLController]
    public int SetLightIntensity;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (light != null) print(SetLightIntensity);
    }
}

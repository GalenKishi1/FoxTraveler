using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class SkyRotating : MonoBehaviour
{
    public float skyboxTimeSpeed;
    public float lightSpeedRotate;
    public Transform transformLight;

    void Update()
    {
        transformLight.Rotate(Time.time * lightSpeedRotate , 0, 0 );
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * skyboxTimeSpeed);
    }
}

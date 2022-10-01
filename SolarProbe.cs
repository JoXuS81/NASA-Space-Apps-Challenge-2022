using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolarProbe : MonoBehaviour
{

    public GameObject solarProbe;
    public Transform Sun;

    public void LookAtTheSun()
    {
        solarProbe.transform.LookAt(Sun);
    }

    public void Update()
    {
        LookAtTheSun();
    }

}
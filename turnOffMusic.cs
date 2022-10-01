using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turnOffMusic : MonoBehaviour
{

    void Start()
    {
        Destroy(GameObject.Find("backgroundMusic"));
    }

}
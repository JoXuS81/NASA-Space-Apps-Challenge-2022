using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class continuousSound : MonoBehaviour
{

    void Start()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

}
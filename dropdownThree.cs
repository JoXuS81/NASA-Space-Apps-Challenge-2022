using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class dropdownThree : MonoBehaviour
{

    public void handleInputData(int val)
    {
        if(val == 0)
        {
            Screen.SetResolution(1280, 1024, true);
        }
    }

}
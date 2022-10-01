using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class dropdownTwo : MonoBehaviour
{

    public void handleInputData(int val)
    {
        if(val == 0)
        {
            Screen.SetResolution(1600, 1200, true);
        }
        if (val == 1)
        {
            Screen.SetResolution(1024, 768, true);
        }
        if (val == 2)
        {
            Screen.SetResolution(800, 600, true);
        }
        if (val == 3)
        {
            Screen.SetResolution(640, 480, true);
        }
    }

}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class dropdownOne : MonoBehaviour
{

    public void handleInputData(int val)
    {
        if(val == 0)
        {
            Screen.SetResolution(1920, 1080, true);
        }
        if (val == 1)
        {
            Screen.SetResolution(1600, 900, true);
        }
        if (val == 2)
        {
            Screen.SetResolution(1366, 768, true);
        }
    }

}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Fullscreen : MonoBehaviour
{

    public void handleInputData(int val)
    {
        if(val == 0)
        {
            Screen.fullScreen = !Screen.fullScreen;
            print("Changed screen mode");
        }
    }

}
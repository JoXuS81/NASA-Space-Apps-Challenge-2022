using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseText : MonoBehaviour
{

    public GameObject earthTextOne;
    public GameObject finalText;
    public GameObject sunText;
    public GameObject sunTextThree;
    public GameObject sunTextTwo;
    public GameObject venusText;

    public void RightClick()
    {
        if(Input.GetMouseButtonDown(1))
        {
            earthTextOne.SetActive(false);
            finalText.SetActive(false);
            sunText.SetActive(false);
            sunTextThree.SetActive(false);
            sunTextTwo.SetActive(false);
            venusText.SetActive(false);
        }
    }

    public void Update()
    {
        RightClick();
    }

}
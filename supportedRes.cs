using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class supportedRes : MonoBehaviour {

    private float aspectRat;
    private int height;
    private int resHeight;
    private int resWidth;
    private int width;
    public GameObject largeRatio;
    public GameObject middleRatio;
    public GameObject smallRatio;

    void Start() {
        UnityEngine.Resolution[] resolutions = Screen.resolutions;
        UnityEngine.Resolution lastItem = resolutions[resolutions.Length - 1];
        resWidth = lastItem.width;
        resHeight = lastItem.height;
        aspectRat = (float)resWidth/resHeight;
        if(aspectRat >= 1.77) {
            Screen.SetResolution(1920, 1080, true);
        }
    }

    void Update() {
        if(aspectRat >= 1.77) {
            middleRatio.SetActive(false);
            smallRatio.SetActive(false);
        }
        else if(aspectRat >= 1.33 || aspectRat <= 1.76) {
            largeRatio.SetActive(false);
            smallRatio.SetActive(false);
           
        }
        else if(aspectRat >= 1.25 || aspectRat <= 1.32) {
            largeRatio.SetActive(false);
            middleRatio.SetActive(false);
        }
    }
    
}
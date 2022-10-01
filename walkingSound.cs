using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walkingSound : MonoBehaviour {

    public AudioSource soundWalk;

    void Update () {
         if (Input.GetKeyDown(KeyCode.UpArrow)) {
             if(!soundWalk.isPlaying) {
                 soundWalk.Play();
             }
         }
         if (Input.GetKeyDown(KeyCode.DownArrow)) {
             if(!soundWalk.isPlaying) {
                 soundWalk.Play();
             }
         }
      
         if (Input.GetKeyUp(KeyCode.UpArrow)) {
             soundWalk.Stop();
         }
         if (Input.GetKeyUp(KeyCode.DownArrow)) {
             soundWalk.Stop();
         }
     }

}
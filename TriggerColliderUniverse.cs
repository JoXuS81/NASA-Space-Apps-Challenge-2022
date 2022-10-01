using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TriggerColliderUniverse : MonoBehaviour
{

    public AudioSource inAppSound;
    public CapsuleCollider earthColliderOne;
    public CapsuleCollider earthColliderThree;
    public CapsuleCollider finalTextCollider;
    public BoxCollider sunColliderOne;
    public BoxCollider sunColliderThree;
    public BoxCollider sunColliderTwo;
    public BoxCollider venusCollider;
    public BoxCollider venusTextCollider;
    public Follower Follower;
    public Transform Earth;
    public GameObject earthTextOne;
    public GameObject finalText;
    public GameObject sunText;
    public GameObject sunTextThree;
    public GameObject sunTextTwo;
    public GameObject Thanks;
    public GameObject venusText;
    public SolarProbe SolarProbe;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Celestial"))
        {
            Follower.Speed = 0.1f;
        }
        if (other.CompareTag("earthColliderOne"))
        {
            Follower.Speed = 0.01f;
            earthTextOne.SetActive(true);
        }
        if (other.CompareTag("earthColliderThree"))
        {
            Follower.Speed = 0.1f;
        }
        if (other.CompareTag("finalTextCollider"))
        {
            Follower.Speed = 0.042f;
            finalText.SetActive(true);
        }
        if (other.CompareTag("sunCollider"))
        {
            Follower.Speed = 0.1f;
            sunText.SetActive(true);
        }
        if (other.CompareTag("sunColliderThree"))
        {
            Follower.Speed = 0.1f;
            sunTextThree.SetActive(true);
        }
        if (other.CompareTag("sunColliderTwo"))
        {
            Follower.Speed = 0.1f;
            sunTextTwo.SetActive(true);
        }
        if (other.CompareTag("venusText"))
        {
            venusText.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Celestial"))
        {
            Follower.Speed = 20f;
        }
        if (other.CompareTag("earthColliderOne"))
        {
            Follower.Speed = 20f;
            earthColliderOne.enabled = false;
            earthTextOne.SetActive(false);
        }
        if (other.CompareTag("earthColliderThree"))
        {
            //inAppSound.Stop();
            earthColliderThree.enabled = false;
            Follower.Speed = 0f;
            Thanks.SetActive(true);
        }
        if (other.CompareTag("finalTextCollider"))
        {
            Follower.Speed = 1f;
            finalTextCollider.enabled = false;
            finalText.SetActive(false);
        }
        if (other.CompareTag("sunCollider"))
        {
            Follower.Speed = 10f;
            sunColliderOne.enabled = false;
            sunText.SetActive(false);
        }
        if (other.CompareTag("sunColliderThree"))
        {
            Follower.Speed = 40f;
            SolarProbe.solarProbe.transform.LookAt(Earth);
            sunColliderThree.enabled = false;
            sunTextThree.SetActive(false);
        }
        if (other.CompareTag("sunColliderTwo"))
        {
            Follower.Speed = 10f;
            sunColliderTwo.enabled = false;
            sunTextTwo.SetActive(false);
        }
        if (other.CompareTag("venusText"))
        {
            venusText.SetActive(false);
            venusTextCollider.enabled = false;
        }
    }

}
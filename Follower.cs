using PathCreation;
using TMPro;
using UnityEngine;

public class Follower : MonoBehaviour
{

    float distanceTravelled;
    public float Speed = 20f;
    public PathCreator pathCreator;

    public void SetPath()
    {
        distanceTravelled += Speed * Time.deltaTime;
        transform.position = pathCreator.path.GetPointAtDistance(distanceTravelled);
    }

    void Update()
    {
        SetPath();
    }

}
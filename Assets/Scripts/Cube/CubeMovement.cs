using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    public float movementCounter = 5;
    public float speed = 0.5f;

    GameObject[] destinationPoints;
    Vector3 destinationPoint;

    private void Awake()
    {
        destinationPoints = GameObject.FindGameObjectsWithTag("Destination");
    }

    private void Update()
    {
        movementCounter -= Time.deltaTime;

        if (movementCounter <= 0)
        {
            MoveTo();
        }
    }

    private void MoveTo ()
    {
        int selectedPoint = Random.Range(0, destinationPoints.Length);
        destinationPoint = destinationPoints[selectedPoint].transform.position;

        transform.position = Vector3.Lerp(transform.position, destinationPoint, speed);

        movementCounter = 5;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointFollower : MonoBehaviour
{
    [SerializeField] private GameObject[] waypoints;
    private int currentWPindex = 0;

    [SerializeField] private float speed = 2f;

    private void Update()
    {
        if (Vector2.Distance(waypoints[currentWPindex].transform.position, transform.position) < .1f)
        {
            currentWPindex++;
            if(currentWPindex >= waypoints.Length)
            {
                currentWPindex = 0;
            }
        }
        transform.position = Vector2.MoveTowards(transform.position, waypoints[currentWPindex].transform.position, Time.deltaTime * speed);
    }
}

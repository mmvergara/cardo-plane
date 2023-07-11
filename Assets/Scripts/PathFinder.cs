using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathFinder : MonoBehaviour
{
    [SerializeField] WavesConfigSO waveConfig;
    List<Transform> waypoints;
    int waypointIndex = 0;
    void Start()
    {
        waypoints = waveConfig.GetWaypoints();
        transform.position = waypoints[waypointIndex].position;
        
    }

    void Update()
    {
        FollowPath();
    }

    void FollowPath(){
        // if we haven't reached the last waypoint
        if(waypointIndex < waypoints.Count){
            Vector3 targetPos = waypoints[waypointIndex].position;
            float delta = waveConfig.getMoveSpeed() * Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, targetPos, delta);
            Debug.Log("Moving");
            Debug.Log(transform.position);
            Debug.Log(targetPos); 
            if(transform.position == targetPos){
                Debug.Log("Changing waypoint");
                waypointIndex++;
            }

        // if we have reached the last waypoint
        } else {
            Destroy(gameObject);
            Debug.Log("Reached last waypoint");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Waves Config", fileName = "New Wave Config")]
public class WavesConfigSO : ScriptableObject{

    [SerializeField] Transform pathPrefab;
    [SerializeField] float moveSpeed = 1f;

    public Transform GetStartingWaypoint(){
        return pathPrefab.GetChild(0);
    }

    public List<Transform> GetWaypoints(){
        List<Transform> waypoints = new List<Transform>();
        foreach(Transform child in pathPrefab){
            waypoints.Add(child);
        }
        return waypoints;
    }

    public float getMoveSpeed(){
        return moveSpeed;
    }
    

}

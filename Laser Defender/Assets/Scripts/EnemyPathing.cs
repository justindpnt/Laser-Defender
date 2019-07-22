using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPathing : MonoBehaviour {

    // Configuration Parameters
    WaveConfig waveConfig;
    List<Transform> waypoints;
    int waypointIndex = 0;
    
    // Start is called before the first frame update
    void Start() {
        waypoints = waveConfig.GetWaypoints();
        transform.position = waypoints[waypointIndex].transform.position;
    }

    // Update is called once per frame
    void Update() {
        Move();
    }

    // Set the wave config file so that the wave path points can be read
    public void SetWaveConfig(WaveConfig waveConfig) {
        this.waveConfig = waveConfig;
    }

    // Function to make the enemies move along the wave points
    private void Move() {
        if (waypointIndex <= waypoints.Count - 1) {
            var targetPosition = waypoints[waypointIndex].transform.position;
            var movementThisFrame = waveConfig.GetMoveSpeed() * Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, targetPosition, movementThisFrame);
            if (transform.position == targetPosition) {
                waypointIndex++;
            }
        } else {
            Destroy(gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour {

    // Start is called before the first frame update
    void Awake() {
        SetUpSingleton();
    }

    // Handles the singleton structure to support the main music player
    private void SetUpSingleton() {
        if (FindObjectsOfType(GetType()).Length > 1) {
            Destroy(gameObject);
        } else {
            DontDestroyOnLoad(gameObject);
        }
    }
}

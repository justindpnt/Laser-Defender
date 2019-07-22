using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shredder : MonoBehaviour {

    // Destroy the projectiles once they reach a certain distnce off screen
    private void OnTriggerEnter2D(Collider2D collision) {
        Destroy(collision.gameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageDealer : MonoBehaviour {

    // Configuration Parameters 
    [SerializeField] int damage = 100;

    // Return the damage associated with the damage dealer
    public int GetDamage() {
        return damage;
    }

    // Destroy the associated instance 
    public void Hit() {
        Destroy(gameObject);
    }
}

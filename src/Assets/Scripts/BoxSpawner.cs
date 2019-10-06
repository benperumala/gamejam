using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BoxSpawner : MonoBehaviour {
    public float cooldown;
    public float currCooldown;
    public float numBoxes;
    public float destroyCount;

    // Reference to the Prefab. Drag a Prefab into this field in the Inspector.
    public GameObject Box;

    public void Start() {
        cooldown = 5f;
        currCooldown = cooldown;
        numBoxes = 0;
        destroyCount = 10f;
    }

    // This script will simply instantiate the Prefab when the game starts.
    void Update() {
        currCooldown -= Time.deltaTime;
        if (numBoxes < destroyCount && currCooldown <= 0) {
            Instantiate(Box, new Vector2(0,-0), Quaternion.identity);
            numBoxes += 1;
            currCooldown = cooldown;
        }
    }
}

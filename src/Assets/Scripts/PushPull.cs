using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushPull : MonoBehaviour
{

    private GameObject player;

    void Start() {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update() {
        if (Input.GetButtonUp("Grab") && transform.parent != null) {
            transform.parent = null;
            player.GetComponent<playerMovement>().holding = false;
        }
    }

    private void OnTriggerStay2D(Collider2D collision) {
        if (collision.CompareTag("Player") && Input.GetButtonDown("Grab")
            && player.GetComponent<CharacterController2D>().m_Grounded) {
            transform.SetParent(player.transform);
            player.GetComponent<playerMovement>().holding = true;
            
        }
    }
}

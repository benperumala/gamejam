using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushPull : MonoBehaviour
{

    private GameObject player;
    private Rigidbody2D rb;

    void Start() {
        player = GameObject.FindGameObjectWithTag("Player");
        rb = GetComponent<Rigidbody2D>();
    }

    void Update() {
        if (Input.GetButtonUp("Grab") && transform.parent != null) {
            transform.parent = null;
            player.GetComponent<playerMovement>().holding = false;
            rb = this.gameObject.AddComponent<Rigidbody2D>();
        }
    }

    private void OnTriggerStay2D(Collider2D collision) {
        if (collision.CompareTag("Player") && Input.GetButtonDown("Grab")
            && player.GetComponent<CharacterController2D>().m_Grounded) {
            transform.SetParent(player.transform);
            player.GetComponent<playerMovement>().holding = true;
            Destroy(rb);
        }
    }
}

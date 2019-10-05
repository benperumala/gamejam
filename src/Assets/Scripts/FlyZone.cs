using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public void OnTriggerEnter(Collider other) {
        Debug.Log("test");
        // this.GetComponent<SpriteRenderer>().color = new Color(1f, 0f, 0f);
    }
}

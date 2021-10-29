using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cilinderBehaviour : MonoBehaviour
{
  public Vector3 growScale = new Vector3(1.0f, 1.0f, 1.0f);
  GameObject player;

  void OnCollisionEnter(Collision collision) {
    if (collision.gameObject.name == "Player") {
      transform.localScale += growScale;

      player = GameObject.Find("Player");
      player.GetComponent<charController>().score += 1;
    }
  }
}

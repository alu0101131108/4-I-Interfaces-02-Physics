using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BingusBehaviour : MonoBehaviour
{
  public float speed = 10.0F;
  void Update()
  {
    speed *= Time.deltaTime;
    if (Input.GetKey("i")) {
    transform.Translate(0, 0, speed);
    }
    if (Input.GetKey("m")) {
      transform.Translate(0, 0, -1 * speed);
    }
    if (Input.GetKey("j")) {
      transform.Translate(-1 * speed, 0, 0);
    }
    if (Input.GetKey("l")) {
      transform.Translate(speed, 0, 0);
    }
    speed = 10.0F;
  }

  void OnCollisionEnter(Collision collision) {
    Debug.Log("Bingus collision detected!");
  }
}

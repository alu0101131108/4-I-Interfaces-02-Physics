using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class escapeCilinder : MonoBehaviour
{
  void Update()
  {
    Vector3 playerPos, direction;
    float xDist, zDist, distance = Vector3.Distance(GameObject.Find("Player").transform.position, transform.position);
    if (distance < 10) {
      playerPos = GameObject.Find("Player").transform.position;
      xDist = transform.position.x - playerPos.x;
      zDist = transform.position.z - playerPos.z;
      direction = new Vector3(xDist, 0, zDist).normalized;
      transform.Translate(direction / 5.0F);
    }
  }
}

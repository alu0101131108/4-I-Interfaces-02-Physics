using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A_Cylinder : MonoBehaviour
{
  void Update()
  {
    Vector3 direction;
    if (Input.GetKey("space")) {
      Vector3 playerPos = GameObject.Find("Player").transform.position;
      float xDist = transform.position.x - playerPos.x;
      float zDist = transform.position.z - playerPos.z;
      direction = new Vector3(xDist, 0, zDist).normalized;
      transform.Translate(direction / 5.0F);
    }
  }
}

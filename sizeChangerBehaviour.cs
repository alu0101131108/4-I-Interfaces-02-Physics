using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sizeChangerBehaviour : MonoBehaviour
{
    void Update()
    {
      float playerDist = Vector3.Distance(GameObject.Find("Player").transform.position, transform.position);
      float sphereDist = Vector3.Distance(GameObject.Find("Sphere").transform.position, transform.position);
      Debug.Log(sphereDist);

      if (playerDist < 5) {
        if (transform.localScale.x > 1) {
          transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
        }
      }
      if (sphereDist < 5) {
        if (transform.localScale.x < 5) {
          transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
        }
      }
    }
}

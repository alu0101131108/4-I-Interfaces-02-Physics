using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charController : MonoBehaviour
{
  public int score = 0;
  public float speed = 10.0f;
  public float LateralRotationSpeed = 100.0f;
  public float VerticalRotationSpeed = 100.0f;
  
  void Start()
  {
    
  }

  void Update()
  {
    // Get the horizontal and vertical axis.
    // By default they are mapped to the arrow keys.
    // The value is in the range -1 to 1
    float translation = Input.GetAxis("Vertical") * speed;
    float Yrotation = Input.GetAxis("Horizontal") * LateralRotationSpeed;
    float Xrotation = Input.GetAxis("Mouse ScrollWheel") * VerticalRotationSpeed;

    // Make it move 10 meters per second instead of 10 meters per frame...
    translation *= Time.deltaTime;
    Yrotation *= Time.deltaTime;
    Xrotation *= Time.deltaTime;

    // Move translation along the object's z-axis
    transform.Translate(0, 0, translation);

    // Rotate around our y-axis
    transform.Rotate(0, Yrotation, 0);
    transform.Rotate(Xrotation, 0, 0);
  }
}
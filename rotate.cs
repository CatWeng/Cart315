using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public class Student : Person
//{
//  public int ID;
//}
public class Rotate : MonoBehaviour
{
  public float rotatespeed = 1.5f;
  private string secret = "this is a secret string";
  void Start() {
  }


//fixedUpdate > Update, fixes framerate to 60fps-not dependent on computer speed
  void fixedUpdate()
  {
    this.transform.Rotate(0, rotatespeed, 0);
  }
}

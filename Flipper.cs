using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flipper : MonoBehaviour
{
  public string button = "LeftFlipper";
  void Start()
  {

  }

  void fixedUpdate()
  {
    if (Input.GetButton(button))
    {
      this.GetComponent<HingeJoint>().useMotor = true;
    }
    else
    {
      this.GetComponent<HingeJoint>().useMotor = false;
    }
  }

}

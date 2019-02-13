using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{
  public string button = "Launcher";
  void Start()
  {

  }

  void FixedUpdate()
  {
    if (Input.GetButton(button))
    {
      this.GetComponent<ConstantForce>().enabled = true;
    }
    else
    {
      this.GetComponent<ConstantForce>().enabled = false;
    }
  }

}

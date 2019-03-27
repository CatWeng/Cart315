using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Collectable : MonoBehaviour
{
    private bool collected;
    public GameObject One;
    public GameObject Two;
    public GameObject Three;

    void Start()
    {
//      One = GameObject.FindWithTag("TP");
      One.gameObject.SetActive(false);
      Two.gameObject.SetActive(false);
      Three.gameObject.SetActive(false);

      collected = false;
    }

    void OnTriggerStay(Collider other)
    {
      Destroy(this.gameObject);
      if ( collected == false ){
          One.gameObject.SetActive(true);
          Two.gameObject.SetActive(true);
          Three.gameObject.SetActive(true);

          collected = true;
          }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Teleport : MonoBehaviour
{
    public GameObject objToTP;
    public Transform tpLoc;
    public GameObject player;

    void Start()
    {
      player = GameObject.FindWithTag("Player");
      player.GetComponent<boolean>().teleported = false;
    }

    void OnTriggerStay(Collider other)
    {
      if ( player.GetComponent<boolean>().teleported == false ){
            objToTP.transform.position = tpLoc.transform.position;
            player.GetComponent<boolean>().teleported =  true;
           Invoke("OnExit", 1);
          }
    }

    void OnExit()
    {
      player.GetComponent<boolean>().teleported = false;
    }

}

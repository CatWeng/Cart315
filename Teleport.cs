using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Teleport : MonoBehaviour
{
    public GameObject objToTP;
    public Transform tpLoc;
    public bool teleported;

    void Start()
    {
      teleported = false;
    }

    void OnTriggerStay(Collider other)
    {
      if ( player.teleported == false ){
            objToTP.transform.position = tpLoc.transform.position;
            teleported =  true;
            Invoke("OnExit", 5);
          }
    }

    void OnExit()
    {
      teleported = false;
    }

}

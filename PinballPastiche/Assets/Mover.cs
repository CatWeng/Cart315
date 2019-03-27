
using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour
{
  public float min=2f;
   public float max=3f;
   // Use this for initialization
   void Start () {
       min=transform.position.z;
       max=transform.position.z+3;
   }
   // Update is called once per frame
   void Update () {
       transform.position =new Vector3(transform.position.x, transform.position.y, Mathf.PingPong(Time.time*2,max-min)+min);
   }
}

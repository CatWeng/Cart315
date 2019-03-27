using UnityEngine;
 using System.Collections;

 public class Eat : MonoBehaviour {

   public GameObject player;
   public float minSize = 0.4f;
   public float maxSize = 10f;
   public float shrinkSpeed = 0.4f;
   public bool shrinking;

   void start(){
     player = GameObject.FindWithTag("Cube");
     shrinking = true;

  //   player.gameObject.transform.localScale -= new Vector3(0, 0, 1);
   }


    void Update() {
        if (shrinking) {
            player.transform.localScale -= Vector3.one*Time.deltaTime*shrinkSpeed;
            if (player.transform.localScale.z < minSize){
                shrinking = false;
              }
        }
    }
     void OnCollisionEnter(Collision col){
         if(col.gameObject.tag == "Food"){
           Debug.Log("collided");
            if(col.transform.localScale.z < player.transform.localScale.z){
              if (player.transform.localScale.z < maxSize){
                gameObject.transform.localScale += Vector3.one*col.transform.localScale.z;
              }
           Destroy(col.gameObject);
          }
         }
     }
 }

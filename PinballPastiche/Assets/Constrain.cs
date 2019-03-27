
using UnityEngine;
using System.Collections;

public class Constrain : MonoBehaviour
{

public float minY = -5.0f, maxY = 4.0f;

void Update() {
    // get the position to a variable
    Vector3 currentPosition = transform.position;
    // modify the variable to keep y within minY to maxY
    currentPosition.y =
       Mathf.Clamp( currentPosition.y, minY, maxY);
    // and now set the transform position to our modified vector
    transform.position = currentPosition;
}
}
// code source https://forum.unity.com/threads/limit-value-of-the-position-x-help.81557/

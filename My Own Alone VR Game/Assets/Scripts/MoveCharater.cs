using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharater : MonoBehaviour{
    public GameObject parent;
    void Start(){
        
    }
    void Update(){
        /*
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit)) {
                // move the charater to the hit point x and z
                parent.transform.position = new Vector3(hit.point.x, transform.position.y, hit.point.z);
            }
        */
    }
    // get im mouse is over the charater
    void OnMouseOver() {
        /*
        // move the charater to mouse position
        if (Input.GetMouseButton(0)) {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit)) {
                // move the charater to the hit point x and z
                transform.position = new Vector3(hit.point.x, transform.position.y, hit.point.z);
            }
        }
        */
    }

}

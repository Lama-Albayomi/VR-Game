using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHand : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if raycast fom mouse postion hits a gameobject then move this to mouse position
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit)) {
            // move the charater to the hit point x and z
            transform.position = new Vector3(hit.point.x, transform.position.y, hit.point.z);
        }

    }
}

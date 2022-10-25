using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHand : MonoBehaviour
{
    Rigidbody body;
    GameObject heldObject;
    bool holdingObject = false;
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();
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

        if (Input.GetMouseButtonUp(0) && heldObject!=null) {
            Debug.Log("Drop Object");
            DropObject();    
        }


    }
    public void HoldObject(GameObject obj) {
        heldObject = obj;
        obj.GetComponent<HingeJoint>().connectedBody=body;
    }
    public void DropObject() {
        // remove joint 
        GameObject charater = heldObject.transform.GetChild(0).gameObject;
        charater.transform.parent=null;

        heldObject.SetActive(false);

        // snap to grid 
        Vector3 pos  = charater.transform.position;
        pos.x = Mathf.Round(pos.x);
        pos.z = Mathf.Round(pos.z);
        pos.y = 0.5f;

        charater.transform.rotation = Quaternion.identity;
        charater.transform.position = pos;
        heldObject = null;
    }
}

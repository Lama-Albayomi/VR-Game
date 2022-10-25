using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharaterButton : MonoBehaviour
{
    public GameObject charaterPrefab;
    public GameObject hand;
    void Start(){

    }
    void Update(){
        
    }
    public void AssignCharater() {
        // assign the charater to the grid
    }
    public void InstantiateCharater() {
        Debug.Log("Instantiate Charater");
        Vector3 pos = hand.transform.position;
        pos.y-=1;
        GameObject charater = Instantiate(charaterPrefab,pos,Quaternion.identity);
        charater.GetComponent<HingeJoint>().connectedBody=hand.GetComponent<Rigidbody>();
        //charater.transform.parent = hand.transform;

    }
}

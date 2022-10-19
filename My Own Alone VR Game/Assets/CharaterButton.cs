using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharaterButton : MonoBehaviour
{
    public GameObject charaterPrefab;
    void Start(){

    }
    void Update(){
        
    }
    public void AssignCharater() {
        // assign the charater to the grid
    }
    public void InstantiateCharater() {
        Debug.Log("InstantiateCharater");
        Vector3 pos = new Vector3(0, 0.5f, 0);
        GameObject charater = Instantiate(charaterPrefab,pos,Quaternion.identity);
    }
}

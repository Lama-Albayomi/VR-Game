using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class CharaterController : MonoBehaviour
{
    // input values
    public float speed = 1;

    // refrenses
    public Transform head= null;
    public XRController controller;
    public ActionBasedController controller1;

    // components
    private CharacterController character;

    //values
    private Vector2 currentDirection = Vector2.zero;

    void Start(){
        character = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update(){
        // check if character is enabled
        if (controller.enableInputActions){
            CheckForMovement(controller.inputDevice);
        }
    }
    private void CheckForMovement(InputDevice device){
        // look for movement
        if (device.TryGetFeatureValue(CommonUsages.primary2DAxis, out Vector2 axis)){
            CalculateDirection(axis);
            MoveCharacter();
            OrientMesh();
        }
    }
    private void CalculateDirection(Vector3 axis){
        // calculate direction
        Vector3 newDirection = new Vector3(axis.x, 0, axis.y);
        Vector3 headRotation = new Vector3(0,head.transform.eulerAngles.y,0);
        currentDirection = Quaternion.Euler(headRotation) * newDirection;
    }
    private void MoveCharacter(){
        // move character
        Vector3 movement = currentDirection * speed;
        character.SimpleMove(movement);
    }
    private void OrientMesh(){
        // orient character
        if (currentDirection != Vector2.zero){
            transform.forward = currentDirection;
        }
    }
}

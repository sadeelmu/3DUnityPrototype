using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
      
    void Start()
    { }

    //variables defined here but can be later edited in unity editor

    private float speed = 13.0f; //variable used for vechile speed fotward
 
    private float turnSpeed = 10.0f; //variable used for vechile speed right and left

    private float horizontalInput;  //variables used in order to control input manager in the horiziontal axes

    private float forwardInput; //variable used in order to control input manager in the vertical axes

        
    void Update()
    {
        forwardInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        //Move the car forwar using the forwardInput variable to control speed of the vechile
        transform.Translate(Vector3.forward * Time.deltaTime * speed *forwardInput);

        //Roate the car using the horizontalInput variable to gain control of the vehicle
        transform.Rotate(Vector3.up,turnSpeed * horizontalInput  * Time.deltaTime); 

    }
}

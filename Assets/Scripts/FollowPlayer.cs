using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    void Start()
    { }

    //player object later assigned to vechile
    public GameObject player;

    //add offset so position is fixed above 
    private Vector3 offset = new Vector3(0, 4, -13);
    // Update is called once per frame

    //changed to late update to stop shakey camera
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
        //will update the position of the camera when the position
        //of the vechile updates in order for the camera to follow the player

    }
}

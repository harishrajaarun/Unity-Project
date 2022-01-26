using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    //we make the camera folow the player
    public GameObject player;
    private Vector3 offset = new Vector3(0, 5, -7);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    //LateUpdate waits for vehicle update and then the camera follows to prevent stuttering(vehicle and camera moves at different speed)
    void LateUpdate()
    {
        //offset the camera behind the player by adding to the player's position
        transform.position = player.transform.position + offset;
    }
}

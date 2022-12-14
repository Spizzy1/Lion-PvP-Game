using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    bool followsPlayer;
    public bool FollowsPlayer { set { followsPlayer = value; } }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (followsPlayer) //Sets the camera position if the camera is supposed to follow the player.
        {
            gameObject.transform.position = new Vector3(GameObject.FindGameObjectWithTag("Player").transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
        }
        else
        {
            gameObject.transform.position = new Vector3(0, gameObject.transform.position.y, gameObject.transform.position.z);
        }
    }
}

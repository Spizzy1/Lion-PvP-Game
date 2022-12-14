using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMapPlayer : MonoBehaviour
{
    bool win = true; //checks if game is won;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if (win)
        {
            GameObject.FindGameObjectWithTag("MainCamera").GetComponent<CameraManager>().FollowsPlayer = true;
            if(gameObject.transform.position.x >= 5 || gameObject.transform.position.x <= -5)
            {
                GameObject.Find("MapManager").GetComponent<MapManager>().loadMap();
                win = false;
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMapPlayer : MonoBehaviour
{
    bool win = true; //checks if game is won;
    bool gamestart = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if (win) //Checks until you're close enough to load a new map
        {
            GameObject.FindGameObjectWithTag("MainCamera").GetComponent<CameraManager>().FollowsPlayer = true;
            if(gameObject.transform.position.x > 15 || gameObject.transform.position.x < -15)
            {
                gamestart = false;
                GameObject.Find("MapManager").GetComponent<MapManager>().loadMap();
            }
        }
        if(gameObject.transform.position.x < 1 && gameObject.transform.position.x > -1 && gamestart == false)
        {
            GameObject.FindGameObjectWithTag("MainCamera").GetComponent<CameraManager>().FollowsPlayer = false;
            GameObject.Find("MapManager").GetComponent<GameManage>().StartGame();
            gamestart = true;
            win = false;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManage : MonoBehaviour
{
    [SerializeField]
    GameObject[] players;
    [SerializeField]
    GameObject wall;
    List<GameObject> walls = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void StartGame()
    {
        foreach (GameObject players in GameObject.FindGameObjectsWithTag("Player"))
        {
            Destroy(players);
        }
        walls.Add(Instantiate(wall, new Vector3(9.5f, 0, 0), Quaternion.identity));
        walls.Add(Instantiate(wall, new Vector3(-9.5f, 0, 0), Quaternion.identity));
        Instantiate(players[0], GameObject.Find("SpawnPlayer1").transform.position, Quaternion.identity);
        Instantiate(players[1], GameObject.Find("SpawnPlayer2").transform.position, Quaternion.identity);
    }
    public void EndGame()
    {
        foreach(GameObject wall in walls)
        {
            walls.Remove(wall);
            Destroy(wall);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapManager : MonoBehaviour
{
    [SerializeField]
    GameObject[] maps;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void loadMap() //selects a random map to load in when progressing to next stage
    {
        int randomIndex = Random.Range(0, maps.Length);
        float winPlayerX = GameObject.FindGameObjectWithTag("Player").transform.position.x;
        GameObject loadedMap = Instantiate(maps[randomIndex], new Vector3(winPlayerX/Mathf.Abs(winPlayerX) * 10, 0, 0), Quaternion.identity);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

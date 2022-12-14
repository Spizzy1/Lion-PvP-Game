using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class MapManager : MonoBehaviour
{
    [SerializeField]
    List<GameObject> maps = new List<GameObject>();
    [SerializeField]
    GameObject platform;
    GameObject platformInstance;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void loadMap() //selects a random map to load in when progressing to next stage
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        player.transform.position = new Vector3(player.transform.position.x/Mathf.Abs(player.transform.position.x) * -1 * 15, player.transform.position.y, player.transform.position.z);
        List<GameObject> saveObjects = new List<GameObject>();
        saveObjects = maps;
        foreach(Transform child in gameObject.transform) //Removes the current map
        {
            saveObjects = saveObjects.Where(x => x != child.gameObject).ToList();
            Destroy(child.gameObject);
        }
        int randomIndex = Random.Range(0, saveObjects.Count);
        float winPlayerX = GameObject.FindGameObjectWithTag("Player").transform.position.x;
        GameObject loadedMap = Instantiate(saveObjects[randomIndex], new Vector3(0, 0, 0), Quaternion.identity, GameObject.Find("MapManager").transform);

    }

    // Update is called once per frame
    void Update()
    {

    }
}

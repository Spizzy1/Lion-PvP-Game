using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class dieScript : MonoBehaviour
{
    private bool gameOver = false;

    public void skillissue () //if tiger sends that it died this happen
    {
        if (gameOver == false)
        {
            gameOver = true;
            Debug.Log("skillissue");
            Invoke("restart", 4f);
        }
        
    }
    void restart()  //loads a new scene
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

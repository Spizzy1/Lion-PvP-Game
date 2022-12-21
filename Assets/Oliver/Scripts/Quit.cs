using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour
{
    [SerializeField]
    KeyCode Backspace;

    public void QuitGame()
    {
        if (Input.GetKeyDown(Backspace))
        {
            Application.Quit();
        }
        
    }


}

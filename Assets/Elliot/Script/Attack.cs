using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    [SerializeField]
    KeyCode attack;

  


    bool attacking;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(attack)) 
        {
            attacking = true;
        }

        
    }

    private void OnTriggerEnter2D(Collider2D collider) 
    {

        if (attacking == true && collider.gameObject.GetComponent(typeof(Component)).ToString().IndexOf("Right Player") > -1)  //detta ska förstöra fienden när man attackerar och den är inom range
        {

            Destroy(collider.gameObject);
           
        }
      
    }
}

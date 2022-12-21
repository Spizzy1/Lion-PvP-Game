using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Attack : MonoBehaviour
{
    float timerAttackCooldown;

    float timerAttackDuration;

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
        timerAttackCooldown += Time.deltaTime;
        timerAttackDuration += Time.deltaTime;

        if (Input.GetKeyDown(attack))
        {
            attacking = true;

        }

        if (timerAttackCooldown > 0.5f)
        {
            timerAttackCooldown = 0;
        }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {

        if (attacking == true && collider.gameObject.GetComponent(typeof(Component)).ToString().IndexOf("Left Player") > -1)  //detta ska förstöra fienden när man attackerar och den är inom range
        {

            Destroy(collider.gameObject);

        }

    }
}

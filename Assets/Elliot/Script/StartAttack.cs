using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAttack : MonoBehaviour
{
    [SerializeField]
    KeyCode startAttack;

    [SerializeField]
    GameObject attackObject;

    [SerializeField]
    Transform lionLocation;

    float attackCooldown;

    float attackRecharge = 2.5f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        

        attackCooldown += Time.deltaTime;

        

        if (Input.GetKeyDown(startAttack) && attackCooldown >= attackRecharge)
        {
            Instantiate(attackObject, lionLocation.position, Quaternion.identity);
            attackCooldown = 0;
        }
    }

}


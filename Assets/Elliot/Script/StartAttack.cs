using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAttack : MonoBehaviour
{
    [SerializeField]
    KeyCode startAttack; // spawna attacken

    [SerializeField]
    GameObject attackObject; // collision objektet

    [SerializeField]
    Transform lionLocation; //var lejonet som attackerar �r (var attacken kommer ifr�n)

    float attackCooldown;

    float attackRecharge = 2.5f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        

        attackCooldown += Time.deltaTime; // ger tid till timern

        

        if (Input.GetKeyDown(startAttack) && attackCooldown >= attackRecharge) //spawnar attack n�r man trycker p� knappen
        {
            Instantiate(attackObject, lionLocation.position, Quaternion.identity);
            attackCooldown = 0; //startar cooldown fr�n 0
        }
    }

}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class V2Attack : MonoBehaviour
{


    [SerializeField]
    string targetPlayer; // vem attacken ska kolla efter kollision med (d�da)

    float attackDurationTimer;

    float attackDuration = 1f;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        attackDurationTimer += Time.deltaTime; // ger tid till timern
        
        
        




        if (attackDurationTimer >= attackDuration) //tar bort attacken n�r tiden �r slut
        {
            Destroy(gameObject);
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent(typeof(Component)).ToString().IndexOf(targetPlayer) > -1) // det h�r f�rst�r fienden n�r skottet tr�ffar och l�gger till po�ng i scores
        {

            Destroy(collision.gameObject);
            
        }
    }
}

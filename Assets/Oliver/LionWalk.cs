using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LionWalk : MonoBehaviour
{
    [SerializeField]
    KeyCode left;
    [SerializeField]
    KeyCode right;
    [SerializeField]
    KeyCode zeta;




    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, -9f, 3.5f), 0);

        if (Input.GetKey(left))
        {
            transform.position += new Vector3(-3, 0, 0) * Time.deltaTime;
        }
        if (Input.GetKey(right))
        {
            transform.position += new Vector3(3, 0, 0) * Time.deltaTime;
        }
    }
}

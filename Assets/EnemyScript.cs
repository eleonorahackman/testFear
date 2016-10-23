using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour
{  //Enemy movement
    public float speed;
    public float jump;
    public Transform enemy;
    float movevelocity;

    bool grounded = true;





    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        //Jumping
        if ( Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (grounded)
            {
                grounded = false;
                GetComponent<Rigidbody>().velocity = new Vector2(GetComponent<Rigidbody>().velocity.x, jump);
            }
        }


        // left, right movement (2d)
        movevelocity = 0;

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            movevelocity = -speed;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            movevelocity = speed;
        }

        


        GetComponent<Rigidbody>().velocity = new Vector2(movevelocity, GetComponent<Rigidbody>().velocity.y);
    }
}
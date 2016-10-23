using UnityEngine;
using System.Collections;

public class CharcterControllerScript : MonoBehaviour
{  //Player movement
    public float speed;
    public float jump;
    public Transform player;
    float movevelocity;
    Vector2 realVelocity;

    bool grounded = true;





	// Use this for initialization
	void Start ()
    {
	}

    // Update is called once per frame
    void Update()
    {

        //Jumping
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.Z))
        {
            if (grounded)
            {
                grounded = false;
                GetComponent<Rigidbody>().velocity = new Vector2(GetComponent<Rigidbody>().velocity.x, jump);
            }
        }


        // left, right movement (2d)
        movevelocity = 0;

        if ( Input.GetKey(KeyCode.A))
        {
            realVelocity.x = -speed;
        }

        if ( Input.GetKey(KeyCode.D))
        {
            realVelocity.x = speed;
        }

        if (Input.GetKeyDown(KeyCode.W)) //this part is a test, new code.... since its not 2d may not work at all...
        {
            realVelocity.y = speed;
         }
        if (Input.GetKeyDown(KeyCode.S))
         {
            realVelocity.y = -speed;
         }


        GetComponent<Rigidbody>().velocity = realVelocity;





      //  if (Input.GetKeyDown(KeyCode.Space))
      //  {
      //   if(grounded)
      // {
      //    grounded = false;
      //     GetComponent<Rigidbody>().velocity = new Vector3(GetComponent<Rigidbody>().velocity.x, jump);
      //    }
      // }
      // if (Input.GetKey(KeyCode.W));
      //  {
      //      transform.position = new Vector3(transform.position.y, transform.position.z + 0.04f);
      // }


        // {
        // void OnCollisionEnter(Collision coll)
        //  {
        //     grounded = true;
        //  }

    }
	}

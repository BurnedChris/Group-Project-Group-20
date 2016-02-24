using UnityEngine;
using System.Collections;

public class LightcycleController : MonoBehaviour
{

    public float period = 0.05f;
    public int direction = 0;

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("Movement", period, period);
    }

    // Update is called once per frame
    void Update()
    {

        // Changes the direction variable based on the key pressed.
        if (Input.GetKeyDown(KeyCode.W))
        {
            direction = 0;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            direction = 1;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            direction = 2;
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            direction = 3;
        }

        // TODO: When direction is changed, we must record this as this is the easiest way to build
        // collidable light walls without overloading the game with objects (slowing it down).
    }

    void Movement()
    {
        //GameObject gameObject = Instantiate(transform.gameObject);
        //gameObject.GetComponent<LightcycleController>().enabled = false;
        Vector3 add = Vector3.zero;
        switch (direction)
        {
            case 0:
                add = new Vector3(0, transform.GetComponent<SpriteRenderer>().sprite.bounds.size.x, 0);
                break;
            case 1:
                add = new Vector3(transform.GetComponent<SpriteRenderer>().sprite.bounds.size.x, 0, 0);
                break;
            case 2:
                add = new Vector3(0, -transform.GetComponent<SpriteRenderer>().sprite.bounds.size.x, 0);
                break;
            case 3:
                add = new Vector3(-transform.GetComponent<SpriteRenderer>().sprite.bounds.size.x, 0, 0);
                break;

        }
        // Cheap reset of velocity. Uses rigidbody to enable collision detection.
        transform.GetComponent<Rigidbody2D>().velocity = add * 10f;
    }

}

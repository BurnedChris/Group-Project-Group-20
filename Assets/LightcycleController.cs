using UnityEngine;
using System.Collections;

public class LightcycleController : MonoBehaviour
{

    public float period = 0.05f;
    public int direction = 0;
    public GameObject trailObject;

    Vector3 startPos;
    GameObject currentTrailObject;
    int scale = 1;

    // Use this for initialization
    void Start()
    {
        startPos = transform.position;
        currentTrailObject = Instantiate<GameObject>(trailObject);
        currentTrailObject.transform.SetParent(GameObject.Find("Walls").transform);
        currentTrailObject.transform.position = startPos;
        InvokeRepeating("Movement", period, period);
    }

    // Update is called once per frame
    void Update()
    {
        int tD = direction;
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
        if(tD != direction)
        {
            fitColliderBetween(currentTrailObject, startPos, transform.position);
            startPos = transform.position;
            currentTrailObject = Instantiate<GameObject>(trailObject);
            currentTrailObject.transform.SetParent(GameObject.Find("Walls").transform);
            currentTrailObject.transform.position = startPos;
            scale = 1;
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
        transform.position += add * 1f;
        fitColliderBetween(currentTrailObject, startPos, transform.position);

    }

    void fitColliderBetween(GameObject co, Vector2 a, Vector2 b)
    {
        // Calculate the Center Position
        co.transform.position = a + (b - a) * 0.5f;

        // Scale it (horizontally or vertically)
        float dist = Vector2.Distance(a, b) * 8;
        if (a.x != b.x)
            co.transform.localScale = new Vector2(dist + 1, 1);
        else
            co.transform.localScale = new Vector2(1, dist + 1);
    }

    void OnCollisionEnter(Collision collision)
    {

    }

}

using UnityEngine;
using System.Collections;

public class Lightcycles : MonoBehaviour {

    public GameObject wallObject;

    public Vector3 direction = Vector3.down;
    GameObject currentWallObject;
    GameObject previousWallObject;

    Vector3 lastChange;

    float yMax = 4.75f;
    float xMax = 12.4f;

	// Use this for initialization
	void Start () {
        changeDirection(direction);
        getPossibleDirections(Vector3.down);
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.W)) {
            changeDirection(Vector3.up);
        }
        if (Input.GetKeyDown(KeyCode.D)) {
            changeDirection(Vector3.right);
        }
        if (Input.GetKeyDown(KeyCode.S)) {
            changeDirection(Vector3.down);
        }
        if (Input.GetKeyDown(KeyCode.A)) {
            changeDirection(Vector3.left);
        }
        fitObjectBetween(currentWallObject, lastChange, transform.position);
        AIControl();
	}

    void changeDirection(Vector3 v) {
        lastChange = transform.position;
        direction = v;
        if(currentWallObject != null){
            Physics.IgnoreCollision(transform.GetComponent<Collider>(), currentWallObject.GetComponent<Collider>(), false);
            previousWallObject = currentWallObject;
        }
        currentWallObject = Instantiate<GameObject>(wallObject);
        Physics.IgnoreCollision(transform.GetComponent<Collider>(), currentWallObject.GetComponent<Collider>(), true);
        GetComponent<Rigidbody>().velocity = v * 2.5f;
    }

    void fitObjectBetween(GameObject o, Vector3 p1, Vector3 p2) {
        o.transform.position = p1 + (p2 - p1) * 0.5f;

        float dist = Vector3.Distance(p1, p2);
        if(p1.x != p2.x)
            o.transform.localScale = new Vector3(dist + 0.4f, 0.4f, 0.4f);
        else
            o.transform.localScale = new Vector3(0.4f, dist + 0.4f, 0.4f);
    }

    void OnTriggerEnter(Collider c) {
        // Who wrote this monstrosity? (c.gameObject != (
        if(c.gameObject != (currentWallObject || previousWallObject)){
            Debug.Log("Hello");
        }
        if (c.gameObject != currentWallObject && (previousWallObject && previousWallObject != c.gameObject)) {
            Destroy(gameObject);
        }
    }

    float getPathRating(Vector3 origin, Vector3 dir, int depth) {
        float d = 0f;
        RaycastHit hit;
        Physics.Raycast(origin + (getPossibleDirections(dir)[0] * 0.2f), dir, out hit);
        if (hit.collider == null || hit.distance > 0.3f) {
            Physics.Raycast(origin - (getPossibleDirections(dir)[0] * 0.2f), dir, out hit);
        }
        //Debug.DrawLine(origin + (dir * 0.2f), origin + (dir * hit.distance), Color.green, 1);
        if (hit.collider != null) {
            d += hit.distance;
            if (d < 0.3f) {
                return d;
            }
            if (depth > 1) {
                float l = -1;
                int de = depth - 1;
                foreach (Vector3 v in getPossibleDirections(direction)) {
                    float t = getPathRating(origin + ((dir * (hit.distance - 0.2f))), v, de);
                    if (t > l) {
                        l = t;
                    }
                }
                d += l;
            }
        }
        return d;
    }

    Vector3[] getPossibleDirections(Vector3 v) {
        Vector3[] vectors = new Vector3[2];
        int i = 0;
        for (int x = -1; x <= 1; x++) {
            for (int y = -1; y <= 1; y++) {
                if (x != y && (x + y == 1 || x + y == -1)) {
                    Vector3 vec = new Vector3(x, y, 0);
                    if (vec == v || vec == -v) {
                        continue;
                    }
                    vectors[i] = vec;
                    i++;
                }
            }
        }
        return vectors;
    }

    float lastChangeTime = 0f;
    void AIControl() {
        if (lastChangeTime + 0.2f > Time.time) {
            return;
        }
        float dangerCheck = getPathRating(transform.position, direction, 6);

        if (dangerCheck < 0.3f) {
            Vector3 nextDir = Vector3.zero;
            float val = 0;
            foreach (Vector3 v in getPossibleDirections(direction)) {
                float t = getPathRating(transform.position, v, 6);
                if (t > val) {
                    nextDir = v;
                    val = t;
                }
            }
            if (val > 0.2f) {
                changeDirection(nextDir);
                lastChangeTime = Time.time;   
            }
        } else {
            float rand = Random.Range(0, 200);
            if (rand < 2) {
                Vector3 nextDir = Vector3.zero;
                float val = 0;
                foreach (Vector3 v in getPossibleDirections(direction)) {
                    float t = getPathRating(transform.position, v, 6);
                    if (t > val) {
                        nextDir = v;
                        val = t;
                    }
                }
                if (val > (dangerCheck / 2)) {
                    changeDirection(nextDir);
                    lastChangeTime = Time.time;
                }
            }
        }
    }

}

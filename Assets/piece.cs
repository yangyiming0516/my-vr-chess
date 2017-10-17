using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class piece : MonoBehaviour {
    public int side; //0 for white, 1 for black
    float height;
    float dest;
    bool lift;
    bool fall;
    public float speed;

	// Use this for initialization
	void Start () {
        lift = false;
        fall = false;
        height = gameObject.transform.position.y;
        speed = 5;
	}
	
	// Update is called once per frame
	void Update () {
        if (lift)
            if (gameObject.transform.position.y < dest)
            {
                gameObject.transform.Translate(Vector3.up * speed * Time.deltaTime);
            }
            else
            {
                lift = false;
            }
        if (fall)
            if (gameObject.transform.position.y > dest)
            {
                gameObject.transform.Translate(Vector3.down * speed * Time.deltaTime);
            }
            else
            {
                fall = false;
            }
	}

    public void goup()
    {
        lift = true;
        dest = height + 3;
    }

    public void godown()
    {
        fall = true;
        dest = height;
    }
}

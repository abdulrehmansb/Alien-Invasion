using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roboMovement : MonoBehaviour
{
    public Vector2 pos1;
    public Vector2 pos2;
    public Vector2 posDiff = new Vector2(5.0f, 0f);
    public float speed = 0.1f;
    bool sw = true;
    private SpriteRenderer sr;
    // Start is called before the first frame update
    void Start()
    {

        sr = GetComponent<SpriteRenderer>();
        pos1 = transform.position;
        pos2 = pos1 + posDiff;

    }

    // Update is called once per frame
    void Update()
    {
        if (sw)
        {
            moveRight();
        }
        if (!sw)
        {
            moveLeft();
        }

        if (transform.position.x >= pos2.x)
        {
            sw = false;
            sr.flipX = true;
        }
        if (transform.position.x <= pos1.x)
        {
            sw = true;
            sr.flipX = false;
        }
    }

    void moveRight()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);
    }

    void moveLeft()
    {
        transform.Translate(-speed * Time.deltaTime, 0, 0);
    }
}

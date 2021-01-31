using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfMovement : MonoBehaviour
{
    Rigidbody2D rb;
    Transform t;
    Vector2 direccion;

    bool front = true;
    bool left = false;
    bool watching = false;

    public float speed = 100f;
    // Start is called before the first frame update
    void Start()
    {
        t = GetComponent<Transform>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        goDirection();

        rb.velocity = direccion * speed * Time.fixedDeltaTime;

    }

    private void goDirection() {
        Debug.Log(t.rotation.z * 180);
    }
}

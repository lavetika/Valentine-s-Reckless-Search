using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsTouching : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log(collision.tag + "ENTRAMOS");
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        //Debug.Log(collision.tag + " SALIMOS");
    }
}

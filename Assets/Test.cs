using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    private void onCollisionEnter2D(Collision2D collision)
    {
        Debug.log(" Collision entered" + collision.gameObject.name);
    }

    private void onCollisionExit2D(Collision2D collision)
    {
        Debug.log(" Collision exited" + collision.gameObject.name);
    }

    private void onCollisionStay2D(Collision2D collision)
    {
        Debug.log(" Collision encurring" + collision.gameObject.name);
    }

    private void onTriggerEnter2D(Collision2D collision)
    {
        Debug.log(" Collision entered" + collision.gameObject.name);
    }

    private void onTriggerExit2D(Collision2D collision)
    {
        Debug.log(" Collision exited" + collision.gameObject.name);
    }

    private void onTriggerStay2D(Collision2D collision)
    {
        Debug.log(" Collision encurring" + collision.gameObject.name);
    }


}

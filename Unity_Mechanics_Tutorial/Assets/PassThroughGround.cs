using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassThroughGround : MonoBehaviour
{
    private bool isPassingThrough = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ground"))
        {
            isPassingThrough = true;
            Physics2D.IgnoreCollision(GetComponent<Collider2D>(), other, true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Ground"))
        {
            isPassingThrough = false;
            Physics2D.IgnoreCollision(GetComponent<Collider2D>(), other, false);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!isPassingThrough)
        {
            // Handle landing on the ground
        }
    }
}


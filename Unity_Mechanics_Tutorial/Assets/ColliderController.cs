using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ColliderController : MonoBehaviour
{
    public KeyCode passThroughKey = KeyCode.Mouse0;
    public LayerMask grappableLayer;
    
    private bool canPassThrough = false;
    private Collider2D currentPassThroughCollider;

    private void Update()
    {
        if (Input.GetKeyDown(passThroughKey) && canPassThrough)
        {
            // Turn off the collider to pass through
            currentPassThroughCollider.enabled = false;
        } 

        else if (Input.GetKeyUp(passThroughKey) !&& canPassThrough)
        {
            currentPassThroughCollider.enabled = true;
        }

    }

    private void OnTriggerEnter2D(Collider2D other) 
        {
            if (other.gameObject.layer == grappableLayer)
            {
            canPassThrough = true;
            currentPassThroughCollider = other;
            }
        }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other == currentPassThroughCollider)
        {
            canPassThrough = false;
            currentPassThroughCollider = null;
        }
    }
    
}



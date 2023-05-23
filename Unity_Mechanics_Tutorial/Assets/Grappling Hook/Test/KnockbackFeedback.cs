using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using DG.Tweening;


public class KnockbackFeedback : MonoBehaviour
{
    public Transform player;
    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {

            player.DOMoveX(10f, 1f);

            
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Animals : MonoBehaviour
{
    public abstract void OnCollide(GameObject interactor);

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            OnCollide(collision.gameObject);
        }
    }
}

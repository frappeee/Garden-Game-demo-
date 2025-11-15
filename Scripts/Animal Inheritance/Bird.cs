using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : Animals
{
    public override void OnCollide(GameObject Interactor)
    {
        Debug.Log("Caw!");
    }
}

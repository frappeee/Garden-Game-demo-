using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duck : Animals
{
    public override void OnCollide(GameObject Interactor)
    {
        Debug.Log("Quack!");
    }
}

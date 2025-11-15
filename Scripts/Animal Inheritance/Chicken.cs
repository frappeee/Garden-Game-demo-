using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chicken : Animals
{
    public override void OnCollide(GameObject Interactor)
    {
        Debug.Log("Bawk!");
    }
}

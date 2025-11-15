using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sheep : Animals
{
    public override void OnCollide(GameObject Interactor)
    {
        Debug.Log("Baa!");
    }
}

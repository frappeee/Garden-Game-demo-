using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pig : Animals
{
    public override void OnCollide(GameObject Interactor)
    {
        Debug.Log("Oink!");
    }
}

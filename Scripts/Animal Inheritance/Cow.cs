using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cow : Animals
{
    public override void OnCollide(GameObject Interactor)
    {
        Debug.Log("Moo!");
    }
}
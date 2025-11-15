using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crops : MonoBehaviour
{
    public void Harvested()
    {
        Destroy(gameObject);
    }
}
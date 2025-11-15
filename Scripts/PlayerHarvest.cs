using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] public int totalCropCount = 0;

    void OnTriggerEnter2D(Collider2D collision)
    {
        Crops crops = collision.GetComponent<Crops>();

        if(crops != null)
        {
            crops.Harvested();

            totalCropCount++;

            Debug.Log("Crop harvested: " + totalCropCount);
        }
    }
}

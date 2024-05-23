using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleLayer : MonoBehaviour
{
    [SerializeField] private GameObject layerLocation;
    [SerializeField] private string tagName;
    public void toggleLayer(bool toggle)
    {
        foreach (Transform child in layerLocation.transform)
        {
            if (child.gameObject.CompareTag(tagName))
                child.gameObject.SetActive(toggle);
        }
    }
}

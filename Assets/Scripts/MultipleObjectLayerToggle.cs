using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class MultipleObjectLayerToggle : MonoBehaviour
{
    [SerializeField] private GameObject[] layerLocations;
    [SerializeField] private GameObject head;
    [SerializeField] private GameObject underwear;
    [SerializeField] private string tagName;
    private string[] matParts = {"Torso", "RLeg", "LLeg"};

    public void toggleLayer(bool toggle)
    {
        Material undMat = underwear.GetComponent<MeshRenderer>().material;
        Material normal = head.GetComponent<SkinnedMeshRenderer>().material;
        foreach (GameObject go in layerLocations)
        {
            if (matParts.Contains(go.name))
            {
                if (!toggle && go.transform.childCount < 0)
                    go.GetComponent<SkinnedMeshRenderer>().material = undMat;
                else
                    go.GetComponent<SkinnedMeshRenderer>().material = normal;
            }
            foreach (Transform child in go.transform)
            {
                child.gameObject.SetActive(toggle);
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class Sweep : MonoBehaviour
{
    [SerializeField] private GameObject[] sweepable;
    [SerializeField] private GameObject und;
    private string[] defaultClothing = {"Torso", "LLeg", "RLeg"};
    public void SweepObjects()
    {
        foreach (GameObject obj in sweepable)
        {
            if (defaultClothing.Contains(obj.gameObject.name))
            {
                obj.GetComponent<SkinnedMeshRenderer>().material = und.GetComponent<MeshRenderer>().material;
            }
            foreach (Transform child in obj.transform)
            {
                Destroy(child.gameObject);
            }
        }     
    }
}

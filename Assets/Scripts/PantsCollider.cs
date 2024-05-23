using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PantsHitbox : MonoBehaviour
{
    [Header("Attachments")]
    [SerializeField] private GameObject head;
    [SerializeField] private GameObject rightlegAtt;
    [SerializeField] private GameObject leftlegAtt;

    private Material skinmat;

    [Header("Body Parts with Underwear")]
    [SerializeField] private GameObject leftlegBody;
    [SerializeField] private GameObject rightlegBody;

    void OnTriggerEnter2D(Collider2D other)
    {
        skinmat = head.GetComponent<SkinnedMeshRenderer>().material;
        if (other.gameObject.tag == "Pants")
        {
            DestroyAllChildren(leftlegAtt);
            DestroyAllChildren(rightlegAtt);
            PantsHolder pantsHolder = other.gameObject.GetComponent<PantsHolder>();

            leftlegBody.GetComponent<Renderer>().material = skinmat;
            rightlegBody.GetComponent<Renderer>().material = skinmat;

            GameObject leftleg = Instantiate(pantsHolder.leftleg);
            leftleg.transform.SetParent(leftlegAtt.transform, false);

            GameObject rightleg = Instantiate(pantsHolder.rightleg);
            rightleg.transform.SetParent(rightlegAtt.transform, false);
            Destroy(other.gameObject);
        }
    }
    void DestroyAllChildren(GameObject obj)
    {
        foreach (Transform child in obj.transform)
        {
            Destroy(child.gameObject);
        }
    }
}

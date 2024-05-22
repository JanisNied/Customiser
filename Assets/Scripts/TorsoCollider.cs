using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorsoCollider : MonoBehaviour
{
    [Header("Attachments")]
    [SerializeField] private GameObject torsoAtt;
    [SerializeField] private GameObject leftarmAtt;
    [SerializeField] private GameObject rightarmAtt;

    [Header("Materials")]
    [SerializeField] private Material skinmat;
    [SerializeField] private Material underwearmat;

    [Header("Body Parts with Underwear")]
    [SerializeField] private GameObject torsoBody;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Shirt")
        {
            DestroyAllChildren(torsoAtt);
            DestroyAllChildren(leftarmAtt);
            DestroyAllChildren(rightarmAtt);
            ShirtsHolder shirtsHolder = other.gameObject.GetComponent<ShirtsHolder>();

            torsoBody.GetComponent<Renderer>().material = skinmat;

            GameObject newTorso = Instantiate(shirtsHolder.torso);
            newTorso.transform.SetParent(torsoAtt.transform, false);

            GameObject leftArm = Instantiate(shirtsHolder.leftarm);
            leftArm.transform.SetParent(leftarmAtt.transform, false);

            GameObject rightArm = Instantiate(shirtsHolder.rightarm);
            rightArm.transform.SetParent(rightarmAtt.transform, false);
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TorsoCollider : MonoBehaviour
{
    [Header("Attachments")]
    [SerializeField] private GameObject head;
    [SerializeField] private GameObject torsoAtt;
    [SerializeField] private GameObject leftarmAtt;
    [SerializeField] private GameObject rightarmAtt;
    [SerializeField] private Toggle tgl;

    private Material skinmat;

    [Header("Body Parts with Underwear")]
    [SerializeField] private GameObject torsoBody;

    void OnTriggerEnter2D(Collider2D other)
    {
        skinmat = head.GetComponent<SkinnedMeshRenderer>().material;
        if (other.gameObject.CompareTag("Shirt"))
        {
            DestroyAllChildren(torsoAtt);
            DestroyAllChildren(leftarmAtt);
            DestroyAllChildren(rightarmAtt);
            ShirtsHolder shirtsHolder = other.gameObject.GetComponent<ShirtsHolder>();

            if (tgl.isOn)
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

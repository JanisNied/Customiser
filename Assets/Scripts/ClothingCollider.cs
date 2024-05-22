using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ClothingCollider : MonoBehaviour
{
    public string usedSkin = "Normal";
    [SerializeField] private GameObject character;

    [Header("Attachments")]
    [SerializeField] private GameObject headAtt;
    [SerializeField] private GameObject torsoAtt;
    [SerializeField] private GameObject leftarmAtt;
    [SerializeField] private GameObject rightarmAtt;
    [SerializeField] private GameObject rightlegAtt;
    [SerializeField] private GameObject leftlegAtt;

    [Header("Materials")]
    [SerializeField] private Material skinmat;
    [SerializeField] private Material underwearmat;

    [Header("Body Parts with Underwear")]
    [SerializeField] private GameObject torsoBody;
    [SerializeField] private GameObject leftlegBody;
    [SerializeField] private GameObject rightlegBody;

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
        }

        if (other.gameObject.tag == "Hat" || other.gameObject.tag == "Hair")
        {
            DestroyAllChildrenTagged(headAtt, other.gameObject.tag);
            SingleObjectActivate objectholder = other.gameObject.GetComponent<SingleObjectActivate>();
            
            GameObject newHat = Instantiate(objectholder.piece);
            newHat.tag = other.gameObject.tag;
            newHat.transform.SetParent(headAtt.transform, false);
        }

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
        }
        Destroy(other.gameObject);
    }
    void DestroyAllChildren(GameObject obj)
    {
        foreach (Transform child in obj.transform)
        {
            Destroy(child.gameObject);
        }
    }
    void DestroyAllChildrenTagged(GameObject obj, string tag)
    {
        foreach (Transform child in obj.transform)
        {
            if (child.gameObject.tag == tag)
                Destroy(child.gameObject);
        }
    }
    void swapSkin(string skin)
    {
        usedSkin = skin;
    }
}

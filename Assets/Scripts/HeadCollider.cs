using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadCollider : MonoBehaviour
{
    [Header("Attachments")]
    [SerializeField] private GameObject headAtt;
    [SerializeField] private AudioSource asrc;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Hat" || other.gameObject.tag == "Hair")
        {
            DestroyAllChildrenTagged(headAtt, other.gameObject.tag);
            SingleObjectActivate objectholder = other.gameObject.GetComponent<SingleObjectActivate>();

            GameObject newHat = Instantiate(objectholder.piece);
            newHat.tag = other.gameObject.tag;
            newHat.transform.SetParent(headAtt.transform, false);
            Destroy(other.gameObject);
            asrc.Play();
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
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LayerChecker : MonoBehaviour
{
    [SerializeField] private Toggle tgBtn;
    [SerializeField] private string tagStr;
    private void OnTransformChildrenChanged()
    {
        foreach(Transform child in transform)
        {
            if (child.gameObject.CompareTag(tagStr))
                child.gameObject.SetActive(tgBtn.isOn);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scaling : MonoBehaviour
{
    [SerializeField] private GameObject scalingTarget;
    [SerializeField] private Slider slider;
    private float initialScale = 1f;

    public void ChangeHeight(float val)
    {
        scalingTarget.transform.localScale = new Vector3(scalingTarget.transform.localScale.x, initialScale * val, scalingTarget.transform.localScale.z);
    }
    public void ChangeWidth(float val)
    {
        scalingTarget.transform.localScale = new Vector3(initialScale * val, scalingTarget.transform.localScale.y, scalingTarget.transform.localScale.z);
    }
}

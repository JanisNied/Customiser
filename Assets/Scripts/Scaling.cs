using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scaling : MonoBehaviour
{
    [SerializeField] private GameObject scalingTarget;
    private float initialScale = 1f;

    public void ChangeHeight(float val)
    {
        float x = scalingTarget.transform.localScale.x;
        float y = initialScale * val;
        float z = CalculateGeometricMeanScale(x, y);
        scalingTarget.transform.localScale = new Vector3(x, y, z);
    }
    public void ChangeWidth(float val)
    {
        float x = initialScale * val;
        float y = scalingTarget.transform.localScale.y;
        float z = CalculateGeometricMeanScale(x, y);
        scalingTarget.transform.localScale = new Vector3(x, y, z);
    }

    float CalculateGeometricMeanScale(float scaleX, float scaleY)
    {
        return Mathf.Sqrt(scaleX * scaleY);
    }

    public void ResetScale()
    {
        scalingTarget.transform.localScale = new Vector3(initialScale, initialScale, initialScale);
    }
}

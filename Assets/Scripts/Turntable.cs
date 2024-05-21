using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Turntable : MonoBehaviour
{
    [Header("Attributes")]
    [SerializeField] float rotationSpeed;
    [Header("Keys")]
    [SerializeField] KeyCode leftRotate;
    [SerializeField] KeyCode rightRotate;

    void Update()
    {
        if (Input.GetKey(leftRotate))
        {
            transform.Rotate(Vector3.up * Time.deltaTime * rotationSpeed);
        }
        if (Input.GetKey(rightRotate))
        {
           transform.Rotate(Vector3.down * Time.deltaTime * rotationSpeed); 
        }
    }
}

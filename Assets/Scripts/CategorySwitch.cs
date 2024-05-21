using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CategorySwitch : MonoBehaviour
{
    [SerializeField] private GameObject catHolder;
    [SerializeField] private GameObject butHolder;
    [SerializeField] private GameObject category;

    public void swapCategory()
    {
        foreach (Transform child in catHolder.transform)
        {
            if (child.gameObject.tag != "NoHide")
                child.gameObject.SetActive(false);
        }
        foreach (Transform child in butHolder.transform)
        {
            child.GetComponent<Button>().interactable = true;
        }
        category.SetActive(true);
        Button button = GetComponent<Button>();
        button.interactable = false;
    }
}

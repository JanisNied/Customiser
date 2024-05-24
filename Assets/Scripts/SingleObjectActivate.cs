using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SingleObjectActivate : MonoBehaviour
{
    [SerializeField] public GameObject piece;
    [SerializeField] public Vector3 posOverride;
    [SerializeField] private GameObject dragAndDropPrefab;
    [SerializeField] private string layer;
    [SerializeField] private Sprite imageSprite;
    [SerializeField] private GameObject canvas;
    [SerializeField] private Toggle toggle;

    Vector2 objectPos = new Vector2(115.75f, 331.75f);

    public void CreateObject()
    {
        if (toggle.isOn)
        {
            GameObject GO = Instantiate(dragAndDropPrefab);
            GO.transform.SetParent(canvas.transform, false);
            GO.transform.localPosition = objectPos;
            GO.tag = layer;
            GO.name = layer + "_1";

            GO.GetComponent<Image>().sprite = imageSprite;
            SingleObjectActivate single = GO.AddComponent<SingleObjectActivate>();
            single.piece = this.piece;
            single.dragAndDropPrefab = this.dragAndDropPrefab;
            single.imageSprite = this.imageSprite;
            single.canvas = this.canvas;
            single.objectPos = this.objectPos;
            single.layer = this.layer;
        }
    }
}

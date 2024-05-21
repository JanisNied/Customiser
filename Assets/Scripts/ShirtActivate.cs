using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShirtsHolder : MonoBehaviour
{
    [SerializeField] public GameObject torso;
    [SerializeField] public GameObject leftarm;
    [SerializeField] public GameObject rightarm;
    [SerializeField] private GameObject dragAndDropPrefab;
    [SerializeField] private Sprite imageSprite;
    [SerializeField] private Canvas canvas;

    Vector2 objectPos = new Vector2(115.75f, 2.02f);

    public void CreateObject()
    {
        GameObject GO = Instantiate(dragAndDropPrefab);
        GO.transform.SetParent(canvas.transform, false);
        GO.transform.localPosition = objectPos;
        GO.tag = "Shirt";
        GO.name = "Shirt_1";

        ShirtsHolder newShirtsHolder = GO.AddComponent<ShirtsHolder>();
        newShirtsHolder.torso = this.torso;
        newShirtsHolder.leftarm = this.leftarm;
        newShirtsHolder.rightarm = this.rightarm;
        newShirtsHolder.dragAndDropPrefab = this.dragAndDropPrefab;
        newShirtsHolder.imageSprite = this.imageSprite;
        newShirtsHolder.canvas = this.canvas;
        newShirtsHolder.objectPos = this.objectPos;
    }
}

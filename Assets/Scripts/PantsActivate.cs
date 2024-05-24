using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PantsHolder : MonoBehaviour
{
    [SerializeField] public GameObject leftleg;
    [SerializeField] public GameObject rightleg;
    [SerializeField] private GameObject dragAndDropPrefab;
    [SerializeField] private Sprite imageSprite;
    [SerializeField] private GameObject canvas;
    [SerializeField] private Toggle toggle;

    Vector2 objectPos = new Vector2(115.75f, 2.02f);

    public void CreateObject()
    {
        if (toggle.isOn)
        {
            GameObject GO = Instantiate(dragAndDropPrefab);
            GO.transform.SetParent(canvas.transform, false);
            GO.transform.localPosition = objectPos;
            GO.tag = "Pants";
            GO.name = "Pants_1";

            GO.GetComponent<Image>().sprite = imageSprite;
            PantsHolder newPants = GO.AddComponent<PantsHolder>();
            newPants.leftleg = this.leftleg;
            newPants.rightleg = this.rightleg;
            newPants.dragAndDropPrefab = this.dragAndDropPrefab;
            newPants.imageSprite = this.imageSprite;
            newPants.canvas = this.canvas;
            newPants.objectPos = this.objectPos;
        }
    }
}

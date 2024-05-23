using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    [SerializeField] private Animator an;
    [SerializeField] private string id;

    private bool state = false;

    public void SwapState()
    {
        state = !state;
        an.SetBool(id, state);
    }

}

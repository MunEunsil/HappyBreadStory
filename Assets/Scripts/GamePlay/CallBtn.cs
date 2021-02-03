using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallBtn : MonoBehaviour
{
    public void Appear()
    {
        gameObject.SetActive(true);
    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }
}


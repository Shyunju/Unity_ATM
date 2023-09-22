using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasManager : MonoBehaviour
{
    [SerializeField] private GameObject open;
    [SerializeField] private GameObject close;

    public void OpenCanvas()
    {
        open.SetActive(true);
        close.SetActive(false);
    }
}

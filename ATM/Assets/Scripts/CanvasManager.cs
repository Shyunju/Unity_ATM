using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasManager : MonoBehaviour
{
    [SerializeField] private GameObject open;
    [SerializeField] private GameObject close;

    public void OpenCanvas()  //캔버스 액티브 관리
    {
        open.SetActive(true);
        close.SetActive(false);
    }
}

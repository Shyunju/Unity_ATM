using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasManager : MonoBehaviour
{
    [SerializeField] private GameObject open;
    [SerializeField] private GameObject close;

    public void OpenCanvas()  //ĵ���� ��Ƽ�� ����
    {
        open.SetActive(true);
        close.SetActive(false);
    }
}

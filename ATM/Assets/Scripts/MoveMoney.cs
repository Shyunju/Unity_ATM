using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class MoveMoney : MonoBehaviour
{
    [SerializeField] private TMP_Text textBalanceMoney;
    [SerializeField] private TMP_Text textCurrentMoney;
    [SerializeField] private TMP_InputField inputTextMoney;
    [SerializeField] private GameObject popUp;

    private int balanceMoney = 50000;
    private int currentMoney = 100000;

    public void Input()
    {
        if (currentMoney < int.Parse(inputTextMoney.text))
        {
            //popup
            popUp.SetActive(true);
            inputTextMoney.text = "금액을 입력하세요​";
        }
        else
        {
            currentMoney -= int.Parse(inputTextMoney.text);
            balanceMoney += int.Parse(inputTextMoney.text);
            textCurrentMoney.text = currentMoney.ToString("#,##0");
            textBalanceMoney.text = balanceMoney.ToString("#,##0");
            inputTextMoney.text = "금액을 입력하세요​";
        }
        
    }

    public void Output()
    {
        if(balanceMoney < int.Parse(inputTextMoney.text))
        {
            //popup
            popUp.SetActive(true);
            inputTextMoney.text = "금액을 입력하세요​";
        }
        else
        {
            currentMoney += int.Parse(inputTextMoney.text);
            balanceMoney -= int.Parse(inputTextMoney.text);
            textCurrentMoney.text = currentMoney.ToString("#,##0");
            textBalanceMoney.text = balanceMoney.ToString("#,##0") ;
            inputTextMoney.text = "금액을 입력하세요​";

        }
    }
}

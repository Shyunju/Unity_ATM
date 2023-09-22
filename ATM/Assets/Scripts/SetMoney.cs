using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;

public class SetMoney : MonoBehaviour
{
    [SerializeField] TMP_InputField textInputMoney;

    public void Setting()
    {
        textInputMoney.text = EventSystem.current.currentSelectedGameObject.name;  //금액버튼 이름으로 inputfield 금액 설정
    }
}

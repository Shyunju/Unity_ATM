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
        textInputMoney.text = EventSystem.current.currentSelectedGameObject.name;
    }
}

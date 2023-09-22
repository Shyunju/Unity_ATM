using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SetName : MonoBehaviour
{
    [SerializeField] private TMP_InputField inputID;
    [SerializeField] private TMP_Text name;

    public void SettingUserName()
    {
        name.text = inputID.text;    //입력한 아이디로 회원정보 이름 설정
    }
}

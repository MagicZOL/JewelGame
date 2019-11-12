using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

//버튼의 정보 저장
public class JewelItemButton : MonoBehaviour
{
    [SerializeField] Text moneyText;

    public Action<JewelItemButton> jewelItemDelegate;

    public JewelItemInfo? jewelItemInfo;

    public void OnClick()
    {
        jewelItemDelegate(this);
        Value();
    }

    public void Value()
    {
        if (jewelItemInfo.HasValue)
        {
            JewelItemInfo jewelItem = jewelItemInfo.Value;
            //moneyText.text += jewelItem.getPrize;
        }
    }
}

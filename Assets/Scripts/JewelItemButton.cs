using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

//버튼의 정보 저장
public class JewelItemButton : MonoBehaviour
{
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

            Money money = GameObject.Find("Money").GetComponent<Money>();
            money.prize = jewelItem.getPrize;

            money.PrizeValue();
        }
    }
}

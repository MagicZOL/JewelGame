using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemPanel : MonoBehaviour
{
    [SerializeField] Text prizeText;

    public Action<ItemPanel> itemPanelDelegate;

    public JewelEquipItemData? jewelEquipItemData;

    public int isTab;
    private void Start()
    {
        itemPanelDelegate(this);

        if(isTab==1)
        {
            Prize();
        }

        else if(isTab==2)
        {
            SellPrize(); 
        }
    }

    public void Prize()
    {
        if (jewelEquipItemData.HasValue)
        {
            prizeText.text = jewelEquipItemData.Value.buyprize.ToString()+"원";
        }
    }

    //판매가격 출력
    public void SellPrize()
    {
        if (jewelEquipItemData.HasValue)
        {
            prizeText.text = jewelEquipItemData.Value.sellPrize.ToString() + "원";
        }
    }
}

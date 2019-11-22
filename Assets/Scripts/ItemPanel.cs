using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemPanel : MonoBehaviour
{
    [SerializeField] Text prizeText;

    public Action<ItemPanel> itemPanelDelegate;

    public JewelEquipItemData? itemPaneljewelEquipItemData;

    public TextDataInfo? textDataInfo;

    private void Start()
    {
        itemPanelDelegate(this);
        if (itemPaneljewelEquipItemData.HasValue)
        {
            prizeText.text = itemPaneljewelEquipItemData.Value.buyprize.ToString() + "원"; //상점버튼클릭시
        }

        if(itemPaneljewelEquipItemData.Value.buyprize > textDataInfo.Value.money)
        {
            GetComponentInChildren<Button>().interactable=false;
        }
    }

    public void ButtonClick()
    {
        itemPanelDelegate(this);
    }
    //public void Prize()
    //{
    //    if (jewelEquipItemData.HasValue)
    //    {
    //        prizeText.text = jewelEquipItemData.Value.buyprize.ToString() + "원"; //상점버튼클릭시
    //    }
    //}

    //public void Sell()
    //{
    //    if(jewelEquipItemData.HasValue)
    //        prizeText.text = jewelEquipItemData.Value.sellPrize.ToString() + "원"; //판매버튼 클릭시
    //}
}

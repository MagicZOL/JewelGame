using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class SellItemPanel : MonoBehaviour
{
   [SerializeField] Text prizeText;

    public Action<SellItemPanel> itemPanelDelegate;

    public JewelEquipItemData? itemPaneljewelEquipItemData;

    private void Start()
    {
        itemPanelDelegate(this);
        if (itemPaneljewelEquipItemData.HasValue)
        {
            prizeText.text = itemPaneljewelEquipItemData.Value.sellPrize.ToString() + "원"; //판매버튼 클릭시
        }

        if(itemPaneljewelEquipItemData.Value.count == 0)
        {
            GetComponentInChildren<Button>().interactable=false;
        }
    }
}

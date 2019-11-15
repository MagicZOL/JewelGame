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

    public List<ScrollViewManager> scrollViewManager;
    private void Start()
    {
        itemPanelDelegate(this);

        if(scrollViewManager[0])
        {
            Prize();
        }
        else if(scrollViewManager[1])
        {
            Sell();
        }
    }

    public void Prize()
    {
        if (jewelEquipItemData.HasValue)
        {
            prizeText.text = jewelEquipItemData.Value.buyprize.ToString() + "원"; //상점버튼클릭시
        }
    }

    public void Sell()
    {
        prizeText.text = jewelEquipItemData.Value.sellPrize.ToString() + "원"; //판매버튼 클릭시
    }
}

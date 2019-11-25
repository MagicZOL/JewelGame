using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemPanel : MonoBehaviour
{
    [SerializeField] Text prizeText;

    public Action<ItemPanel> itemPanelDelegate;
    public Action<ItemPanel> itemPanelOnClickDelegate;
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

    private void Update() {
        textDataInfo =FileManager<TextDataInfo>.Load(Constant.moneyFileName);
        if(itemPaneljewelEquipItemData.Value.buyprize > textDataInfo.Value.money)
        {
            GetComponentInChildren<Button>().interactable=false;
        }
    }
    public void ButtonClick()
    {
        if(itemPaneljewelEquipItemData.Value.buyprize <= textDataInfo.Value.money)
            itemPanelOnClickDelegate(this);
        else
        return;
    }
}

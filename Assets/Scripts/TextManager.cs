using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour
{
    [SerializeField] Text moneyText;
    [SerializeField] Text speedText;
    [SerializeField] Text attackText;
    [SerializeField] ScrollViewManager scrollViewManager;
    [SerializeField] SellScrollViewManager sellScrollViewManager;

    public int prize;
    
    TextDataInfo? textDataInfo;

    public JewelEquipItemDatas? jewelEquipItemDatas;

    private void Awake()
    {
        textDataInfo = FileManager<TextDataInfo>.Load(Constant.moneyFileName);
        scrollViewManager.textDataInfo = textDataInfo;
        sellScrollViewManager.textDataInfo = textDataInfo;
        if(textDataInfo.HasValue)
        {
            moneyText.text = textDataInfo.Value.money.ToString();
        }

        scrollViewManager.ItemNum = (N) =>
        {
            Debug.Log("num :" + N);
        };

        BuyItemClick();
    }
    public void PrizeValue()
    {
        int getprize = int.Parse(moneyText.text) + prize;
        moneyText.text = getprize.ToString();

        TextDataInfo newMoney = textDataInfo.Value;
        newMoney.money = int.Parse(moneyText.text);

        textDataInfo = newMoney;
    }

    private void OnApplicationQuit()
    {
        if(textDataInfo.HasValue)
        FileManager<TextDataInfo>.Save(textDataInfo.Value, Constant.moneyFileName);
    }

    public void BuyItemClick()
    {
        // scrollViewManager.ItemNum = (num) =>
        // {
        //     Debug.Log("num :" + num);
        //     // speedText.text = jewelEquipItemDatas.Value.jewelEquipItemList[num].speed.ToString();
        //     // attackText.text = jewelEquipItemDatas.Value.jewelEquipItemList[num].attack.ToString();
        // };
    }
}

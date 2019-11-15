using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour
{
    [SerializeField] Text moneyText;
    [SerializeField] Text speedText;
    [SerializeField] Text attackText;

    public int prize;
    
    TextDataInfo? textDataInfo;

    private void Awake()
    {
        textDataInfo = FileManager<TextDataInfo>.Load(Constant.moneyFileName);
        if(textDataInfo.HasValue)
        {
            moneyText.text = textDataInfo.Value.money.ToString();
        }
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
}

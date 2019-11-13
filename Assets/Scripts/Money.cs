using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour
{
    [SerializeField] Text moneyText;

    public int prize;
    public void PrizeValue()
    {
        int getprize = int.Parse(moneyText.text) + prize;
        moneyText.text = getprize.ToString();
    }
}

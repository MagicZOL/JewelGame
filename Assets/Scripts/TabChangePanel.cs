using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TabChangePanel : MonoBehaviour
{
    [SerializeField] GameObject[] TabScrollViewPrefab;

    public JewelEquipItemDatas? jewelEquipItemDatas;

    [SerializeField] ScrollViewManager scrollViewManager;
    [SerializeField] SellScrollViewManager sellScrollViewManager;

    public List<GameObject> scrollList;
    private void Awake()
    {
        jewelEquipItemDatas = FileManager<JewelEquipItemDatas>.Load(Constant.ItemFileName);
        for(int i=0; i<TabScrollViewPrefab.Length; i++)
        {
            scrollList.Add(TabScrollViewPrefab[i]);
        }
        ShopOnClick(0);
    }

    public void ShopOnClick(int buttonIndex)
    {
        if (jewelEquipItemDatas.HasValue)
        {
            scrollViewManager.jewelEquipItemDatas = jewelEquipItemDatas;
            sellScrollViewManager.jewelEquipItemDatas = jewelEquipItemDatas;
        }

        for (int i = 0; i < TabScrollViewPrefab.Length; i++)
        {
            if (i == buttonIndex)
            {
                TabScrollViewPrefab[i].SetActive(true);
            }
            else
            {
                TabScrollViewPrefab[i].SetActive(false);
            }
        }
    }
}

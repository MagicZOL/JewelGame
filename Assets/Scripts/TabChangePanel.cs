using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TabChangePanel : MonoBehaviour
{
    [SerializeField] GameObject[] TabScrollViewPrefab;

    public JewelEquipItemDatas? jewelEquipItemDatas;

    [HideInInspector] public ScrollViewManager scrollViewManager;

    public List<ScrollViewManager> scrollViewManagers;

    private void Awake()
    {
        jewelEquipItemDatas = FileManager<JewelEquipItemDatas>.Load(Constant.ItemFileName);
        ShopOnClick(0);
    }

    public void ShopOnClick(int buttonIndex)
    {
        if (jewelEquipItemDatas.HasValue)
        {
            scrollViewManager.jewelEquipItemDatas = jewelEquipItemDatas;
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

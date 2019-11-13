using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TabChangePanel : MonoBehaviour
{
    [SerializeField] GameObject scrollViewPrefab;
    [SerializeField] GameObject scrollViewPrefabSell;
    [SerializeField] GameObject scrollViewPrefabUpgrade;
    [SerializeField] GameObject scrollViewPrefabUp;

    [SerializeField] ItemPanel itemPanel;
    public JewelEquipItemDatas? jewelEquipItemDatas;

    bool isInstat1 = false;
    bool isInstat2 = false;

    ScrollViewManager scrollViewManager;
    ScrollViewManager scrollViewManager2;
    ScrollViewManager scrollViewManager3;

    int i = 0;
    private void Start()
    {
        if(!isInstat1)
        {
            ShopOnClick();
            isInstat1 = true;
        }
    }

    public void ShopOnClick()
    {

        itemPanel.isTab = 1; //상점버튼인지 확인하는 숫자

            scrollViewManager = Instantiate(scrollViewPrefab, transform).GetComponent<ScrollViewManager>();

            if (jewelEquipItemDatas.HasValue)
            {
                scrollViewManager.jewelEquipItemDatas = jewelEquipItemDatas;
            }

        try
        {
            if (scrollViewManager2.gameObject.activeSelf)
            Destroy(scrollViewManager2.gameObject);
        }
        catch (NullReferenceException e)
        {
            Debug.Log("널 오류뜸");
        }
        catch (MissingReferenceException e)
        {
            Destroy(scrollViewManager.gameObject);
        }
    }

    //판매탭을 눌렀을때 
    public void SellOnClick()
    {
        
        itemPanel.isTab = 2; //판매버튼인지 확인하는 숫자

            scrollViewManager2 = Instantiate(scrollViewPrefabSell, transform).GetComponent<ScrollViewManager>();

            if (jewelEquipItemDatas.HasValue)
            {
                scrollViewManager2.jewelEquipItemDatas = jewelEquipItemDatas;
            }

        try
        {
            Destroy(scrollViewManager.gameObject);
        }
        catch (NullReferenceException e)
        {
            return;
        }
        catch (MissingReferenceException e)
        {
            Destroy(scrollViewManager2.gameObject);
        }
    }

    public void UpgradeOnClick()
    {
        itemPanel.isTab = 3; //업그레이드 버튼

        scrollViewManager3 = Instantiate(scrollViewPrefabUpgrade, transform).GetComponent<ScrollViewManager>();

        if (jewelEquipItemDatas.HasValue)
        {
            scrollViewManager3.jewelEquipItemDatas = jewelEquipItemDatas;
        }
    }
}

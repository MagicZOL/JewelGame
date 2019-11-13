using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvenrotyButton : MonoBehaviour
{
    [SerializeField] GameObject inventoryPrefab;

    private void Awake()
    {
        inventoryPrefab.SetActive(false);
    }

    //처음화면에서 인벤토리 이미지 클릭시
    public void InventoryOnClick()
    {
        inventoryPrefab.SetActive(true);
    }

    //인벤토리 화면에서 x버튼 클릭시
    public void InventoryOffClick()
    {
        inventoryPrefab.SetActive(false);
    }
}

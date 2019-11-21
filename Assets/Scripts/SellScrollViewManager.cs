using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SellScrollViewManager : MonoBehaviour
{
    [SerializeField] GameObject itemPanelPrefab;
    [SerializeField] RectTransform content;

    List<ItemPanel> itemList = new List<ItemPanel>();

    public JewelEquipItemDatas? jewelEquipItemDatas;

    public TabChangePanel tabChangePanel;

    private void Awake()
    {
        Sprite[] sprites = SpriteManager.Load("Items");
        MakeImageCell(sprites);
        //tabChangePanel.scrollViewManager = this;
    }

    private void MakeImageCell(Sprite[] sprites)
    {
        foreach (Sprite sprite in sprites)
        {
            ItemPanel itemPanel = Instantiate(itemPanelPrefab, content).GetComponent<ItemPanel>();
            itemPanel.GetComponentInChildren<Image>().sprite = sprite;
            itemList.Add(itemPanel);
            //itemPanel.scrList = ScrList;
            itemPanel.itemPanelDelegate = (itemPanelThis) =>
            {
                if (jewelEquipItemDatas.HasValue)
                {
                    int itemIndex = itemList.IndexOf(itemPanelThis);

                    JewelEquipItemData selectItem = jewelEquipItemDatas.Value.jewelEquipItemList[itemIndex];
                    itemPanel.itemPaneljewelEquipItemData = selectItem;
                }
            };
            //tabChangePanel.scrollViewManager = this; // 스크롤뷰메니저 전달
        }
    }
}

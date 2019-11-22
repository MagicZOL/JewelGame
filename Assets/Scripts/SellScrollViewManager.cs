using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SellScrollViewManager : MonoBehaviour
{
    [SerializeField] GameObject itemPanelPrefab;
    [SerializeField] RectTransform content;

    List<SellItemPanel> itemList = new List<SellItemPanel>();

    public JewelEquipItemDatas? jewelEquipItemDatas;

    public TextDataInfo? textDataInfo;

    private void Awake()
    {
        Sprite[] sprites = SpriteManager.Load("Items");
        MakeImageCell(sprites);
    }

    private void MakeImageCell(Sprite[] sprites)
    {
        foreach (Sprite sprite in sprites)
        {
            SellItemPanel itemPanel = Instantiate(itemPanelPrefab, content).GetComponent<SellItemPanel>();
            itemPanel.GetComponentInChildren<Image>().sprite = sprite;
            itemList.Add(itemPanel);

            itemPanel.itemPanelDelegate = (itemPanelThis) =>
            {
                if (jewelEquipItemDatas.HasValue)
                {
                    int itemIndex = itemList.IndexOf(itemPanelThis);

                    JewelEquipItemData selectItem = jewelEquipItemDatas.Value.jewelEquipItemList[itemIndex];
                    itemPanel.itemPaneljewelEquipItemData = selectItem;
                }
            };
        }
    }
}

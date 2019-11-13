using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollViewManager : MonoBehaviour
{
    [SerializeField] GameObject itemPanelPrefab;
    [SerializeField] RectTransform content;

    List<ItemPanel> itemList = new List<ItemPanel>();

    public JewelEquipItemDatas? jewelEquipItemDatas;
    private void Awake()
    {
        Sprite[] sprites = SpriteManager.Load("Items");
        MakeImageCell(sprites);
    }

    private void MakeImageCell(Sprite[] sprites)
    {
        foreach (Sprite sprite in sprites)
        {
            ItemPanel itemPanel = Instantiate(itemPanelPrefab, content).GetComponent<ItemPanel>();
            itemPanel.GetComponentInChildren<Image>().sprite = sprite;
            itemList.Add(itemPanel);

            itemPanel.itemPanelDelegate = (itemPanelThis) =>
            {
                if (jewelEquipItemDatas.HasValue)
                {
                    int itemIndex = itemList.IndexOf(itemPanelThis);

                    JewelEquipItemData selectItem = jewelEquipItemDatas.Value.jewelEquipItemList[itemIndex];
                    itemPanel.jewelEquipItemData = selectItem;
                }
            };
        }
    }
}

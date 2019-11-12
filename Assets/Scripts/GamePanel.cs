using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//진행중인 게임판넬 - 역할 : 아직게임을 만들수 없어 보석창을 띄우는 역할을 할 예정
public class GamePanel : MonoBehaviour
{
    [SerializeField] GameObject jewelItemPanelPrafab;

    //클릭시 보석창이 떠야 함
    public void GamePanelOnClick()
    {
        JewelItems jewelIteminfo = Instantiate(jewelItemPanelPrafab, transform).GetComponent<JewelItems>();
    }
}

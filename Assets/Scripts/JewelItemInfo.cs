using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//보석들에 대한 정보를 담당하는 스크립트
[System.Serializable]
public struct JewelItemInfo
{
    public string name; //보석이름
    public int getPrize; //얻었을때 가격
    public int prize; //팔때의 가격
    //public string explanation; //보석들 설명
}

public struct JewelItemInfos
{
    public List<JewelItemInfo> jewelItemInfoList;

    public JewelItemInfos(List<JewelItemInfo> jewelItemInfoList)
    {
        this.jewelItemInfoList = jewelItemInfoList;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingButton : MonoBehaviour
{
    [SerializeField] GameObject SettingPanel;
    private void Start() {
        SettingPanel.SetActive(false);
    }
    public void OnClick()
    {
        SettingPanel.SetActive(true);
    }

    public void CancelOnClick()
    {
        SettingPanel.SetActive(false);
    }
}

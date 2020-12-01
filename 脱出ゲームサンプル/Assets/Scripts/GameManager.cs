using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PANEL {
    ROOM,
    LIGHT_STAND,
    DRAWER,
    PC
}

public class GameManager : MonoBehaviour {
    // 各パネルを取得
    public GameObject lightStandPanel;
    public GameObject drawerPanel;
    public GameObject pcPanel;
    [SerializeField] MessageManager messageManager;

    // 現在表示しているパネル
    public PANEL currentPanel = PANEL.ROOM;

    // ボタンを押したら該当するパネルを表示
    public void OnClickLightStandTrigger() {
        currentPanel = PANEL.LIGHT_STAND;
        lightStandPanel.SetActive(true);
    }

    public void OnClickDrawerTrigger() {
        currentPanel = PANEL.DRAWER;
        drawerPanel.SetActive(true);
    }

    public void OnClickPCTrigger() {
        currentPanel = PANEL.PC;
        pcPanel.SetActive(true);
    }

    // ボタンを押したらパネルを全て非表示にする
    public void OnClickBackTrigger() {
        currentPanel = PANEL.ROOM;
        lightStandPanel.SetActive(false);
        drawerPanel.SetActive(false);
        pcPanel.SetActive(false);
        messageManager.ToggleText(false, "");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    // 各パネルを取得
    public GameObject lightStandPanel;
    public GameObject drawerPanel;
    public GameObject pcPanel;

    // ボタンを押したら該当するパネルを表示
    public void OnClickLightStandTrigger() {
        lightStandPanel.SetActive(true);
    }

    public void OnClickDrawerTrigger() {
        drawerPanel.SetActive(true);
    }

    public void OnClickPCTrigger() {
        pcPanel.SetActive(true);
    }

    // ボタンを押したらパネルを全て非表示にする
    public void OnClickBackTrigger() {
        lightStandPanel.SetActive(false);
        drawerPanel.SetActive(false);
        pcPanel.SetActive(false);
    }
}

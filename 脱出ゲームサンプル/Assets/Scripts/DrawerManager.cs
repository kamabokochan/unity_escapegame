using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DrawerManager : MonoBehaviour {
    [SerializeField] GameObject lightBulbPanel;
    [SerializeField] ItemBoxManager itemBoxManager;
    [SerializeField] MessageManager messageManager;

    void Start() {
        LightBulbSetActive(false);
    }

    void LightBulbSetActive(bool isShow) {
        lightBulbPanel.SetActive(isShow);
    }

    bool isGetBulb = false;

    // 引き出しが押されたら
    // 1. 電球の画像を出す
    // 2. Textを出す
    public void OnClickTrigger() {
        // すでに電球をゲットしていたら何もしない
        if (isGetBulb) {
            LightBulbSetActive(false);
            messageManager.ToggleText(true, "もうここには何もないみたいだな・・・");
            return;
        }

        LightBulbSetActive(true);
        messageManager.ToggleText(true, "電球を見つけた");
        itemBoxManager.SetItem(ITEM.LIGHT_BULB);
        isGetBulb = true;
    }

    // 電球の画像をクリックすると電球画像を非表示にする
    public void OnClickImage() {
        LightBulbSetActive(false);
        messageManager.ToggleText(false, "");
    }
}

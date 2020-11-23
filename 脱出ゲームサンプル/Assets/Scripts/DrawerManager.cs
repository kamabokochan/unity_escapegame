using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawerManager : MonoBehaviour {
    [SerializeField] GameObject lightBulbPanel;
    [SerializeField] GameObject alertText;
    [SerializeField] ItemBoxManager itemBoxManager;

    void Start() {
        LightBulbSetActive(false);
    }

    void LightBulbSetActive(bool isShow) {
        lightBulbPanel.SetActive(isShow);
        alertText.SetActive(isShow);
    }

    // 引き出しが押されたら
    // 1. 電球の画像を出す
    // 2. Textを出す
    public void OnClickTrigger() {
        LightBulbSetActive(true);
        itemBoxManager.SetItem(ITEM.LIGHT_BULB);
    }

    // 電球の画像をクリックすると電球画像を非表示にする
    public void OnClickImage() {
        LightBulbSetActive(false);
    }
}

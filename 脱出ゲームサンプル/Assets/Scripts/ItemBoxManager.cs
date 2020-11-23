using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum ITEM {
    NONE,
    LIGHT_BULB
}

public class ItemBoxManager : MonoBehaviour {
    [SerializeField] Sprite lightBulbSprite; // 電球画像
    [SerializeField] Image[] itemBoxImages;
    [SerializeField] LightStandManager lightStandManager;

    ITEM[] itemsList = new ITEM[4]; // 取得したアイテムの配列

    // アイテムを取得した
    public void SetItem(ITEM item) {
        itemsList[0] = item;
        switch (item) {
            case ITEM.LIGHT_BULB:
                itemBoxImages[0].sprite = lightBulbSprite;
                break;
            default:
            case ITEM.NONE:
                itemBoxImages[0].sprite = null;
                break; 
        }
    }

    // アイテムを使用
    public void UseItem(int index) {
        switch (itemsList[index]) {
            case ITEM.LIGHT_BULB:
                lightStandManager.LightSwitch(true);
                break;
            default:
                break;
        }
        itemsList[index] = ITEM.NONE; // アイテムを使用したので空にする
        itemBoxImages[index].sprite = null;
    }
}

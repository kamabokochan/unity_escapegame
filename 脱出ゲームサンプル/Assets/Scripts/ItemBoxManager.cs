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
    [SerializeField] GameManager gameManager;
    // SE
    [SerializeField] AudioClip getItemSE;
    private AudioSource audioSource;

    ITEM[] itemsList = new ITEM[4]; // 取得したアイテムの配列

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // アイテムを取得した
    public void SetItem(ITEM item) {
        audioSource.PlayOneShot(getItemSE);

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
        if (gameManager.currentPanel == PANEL.LIGHT_STAND && itemsList[index] == ITEM.LIGHT_BULB) {
            lightStandManager.LightSwitch(true);
            itemsList[index] = ITEM.NONE; // アイテムを使用したので空にする
            itemBoxImages[index].sprite = null;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LightStandManager : MonoBehaviour {
    [SerializeField] Sprite lightON;
    [SerializeField] Sprite lightOFF;
    [SerializeField] Image image;

    public void LightSwitch(bool isON) {
        if (isON) {
            image.sprite = lightON;
        } else {
            image.sprite = lightOFF;
        }
    }
}

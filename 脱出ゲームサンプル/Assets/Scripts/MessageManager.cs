using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MessageManager : MonoBehaviour {
    public GameObject messagePanel;
    [SerializeField] Text messageText;
    void Start() {
        messagePanel.SetActive(false);
    }

    // テキストの表示と内容の変更を行う
    public void ToggleText(bool isShow, string message) {
        messagePanel.SetActive(isShow);
        messageText.text = message;
    }
}

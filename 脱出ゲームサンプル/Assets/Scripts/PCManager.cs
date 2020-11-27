using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PCManager : MonoBehaviour {
    [SerializeField] Text[] viewPasswordTexts;
    [SerializeField] Text passwordPanelText;

    // ユーザが入力したパスワード
    string userInputPassword = "";

    //　正解のパスワード
    string correctPassword = "3333";

    int currentIndex = 0;

    bool isClear = false;

    public void InputKey(int password) {
        if (isClear) {
            return; // クリアしていたら何も操作させない
        }

        viewPasswordTexts[currentIndex].text = password.ToString();
        userInputPassword += password.ToString();
        currentIndex++;
        if (currentIndex >= viewPasswordTexts.Length) {
            if (CheckPass()) {
                Debug.Log("正解");
                isClear = true;
                passwordPanelText.text = "CLEAR";
                SceneManager.LoadScene("ClearScene");
            } else {
                Debug.Log("はずれ");
                // リセットする
                userInputPassword = "";
                currentIndex = 0;
            }
        }
    }

    bool CheckPass() {
        Debug.Log(userInputPassword);
        return userInputPassword == correctPassword;
    }
}

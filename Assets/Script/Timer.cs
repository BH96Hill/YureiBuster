using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
 
public class TimeCounter : MonoBehaviour
{
    //カウントダウン
    public float countdown = 30.0f;
 
    //時間を表示するText型の変数
    public Text timeText;
 
    // Update is called once per frame
    void Update()
    {
       
        //時間をカウントする
        countdown -= Time.deltaTime;
 
        //時間を表示する
        timeText.text = countdown.ToString("f1");
 
        //countdownが0以下になったとき
        if (countdown <= 0)
        {
            SceneManager.LoadScene("ResultScene");
        }
    }
}
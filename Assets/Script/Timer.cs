using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
 
public class TimeCounter : MonoBehaviour
{
    //�J�E���g�_�E��
    public float countdown = 30.0f;
 
    //���Ԃ�\������Text�^�̕ϐ�
    public Text timeText;
 
    // Update is called once per frame
    void Update()
    {
       
        //���Ԃ��J�E���g����
        countdown -= Time.deltaTime;
 
        //���Ԃ�\������
        timeText.text = countdown.ToString("f1");
 
        //countdown��0�ȉ��ɂȂ����Ƃ�
        if (countdown <= 0)
        {
            SceneManager.LoadScene("ResultScene");
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectObake : MonoBehaviour
{
    //  ���΂��̎�ނ̗���
    int randomNo;
    //  �a���Ă������΂��Ǝa�����Ⴂ���Ȃ����΂��̊m��
    bool probabilityFlag;
    //  ���΂������݂ɏo�鎞��
    float waitTime;

    //  �v���C����
    public float playTimer;

    //  ���E���h���Ƃɑҋ@���Ԃ�ς���
    float fluctuateNum;

    public FadeOutSceneLoader fadeOutSceneLoader;
    // Start is called before the first frame update
    void Start()
    {
        playTimer = 60.0f;
        waitTime = 2.0f;
    }

    // Update is called once per frame
    void Update()
    {
        waitTime -= Time.deltaTime;
        playTimer -= Time.deltaTime;
        GameObject obake1 = GameObject.Find("obake1");
        GameObject obake2 = GameObject.Find("obake2");
        GameObject obake3 = GameObject.Find("obake3");
        GameObject obake4 = GameObject.Find("obake4");
        GameObject obake5 = GameObject.Find("obake5");
        GameObject obake6 = GameObject.Find("obake6");
        GameObject obake7 = GameObject.Find("obake7");

        GameObject obakejanai1 = GameObject.Find("obakejanai1");
        GameObject obakejanai2 = GameObject.Find("obakejanai2");
        GameObject obakejanai3 = GameObject.Find("obakejanai3");
        GameObject obakejanai4 = GameObject.Find("obakejanai4");
        GameObject obakejanai5 = GameObject.Find("obakejanai5");
        GameObject obakejanai6 = GameObject.Find("obakejanai6");
        GameObject obakejanai7 = GameObject.Find("obakejanai7");
        GameObject bombObject = GameObject.Find("bombObject");


        if (playTimer <= 60.0f && playTimer > 50.0f)
        {
            fluctuateNum = 5.0f;
        }
        if (playTimer <= 50.0f && playTimer > 40.0f)
        {
            fluctuateNum = 3.0f;
        }
        if (playTimer <= 40.0f && playTimer > 20.0f)
        {
            fluctuateNum = 2.0f;
        }
        if (playTimer <= 20.0f && playTimer > 0.0f)
        {
            fluctuateNum = 1.0f;
        }

        if (playTimer <= -5.0f)
        {
            fadeOutSceneLoader.CallCoroutine();
        }


        if (playTimer >= 0.0f)
        {
            if (waitTime <= 0.0f)
            {
                Shuffle();
                switch (randomNo)
                {
                    case 0:
                        ProbabilityMachine();
                        if (!probabilityFlag)
                        {
                            if (obakejanai1 != null)
                            {
                                //  obake3��̃X�N���v�g�ւ̎Q�Ƃ��擾
                                Move move = obakejanai1.GetComponent<Move>();
                                if (move != null)
                                {
                                    //  move��moveFlagTrigger���Ăяo��
                                    move.moveFlagTrigger();
                                    move.ChangeLimit(playTimer);
                                    waitTime = fluctuateNum;
                                }
                            }
                        }
                        else
                        {
                            if (obake1 != null)
                            {
                                //  obake1��̃X�N���v�g�ւ̎Q�Ƃ��擾
                                Move move = obake1.GetComponent<Move>();
                                if (move != null)
                                {
                                    //  move��moveFlagTrigger���Ăяo��
                                    move.moveFlagTrigger();
                                    move.ChangeLimit(playTimer);
                                    waitTime = fluctuateNum;
                                }
                            }
                        }

                        break;

                    case 1:
                        ProbabilityMachine();
                        if (!probabilityFlag)
                        {
                            if (obakejanai2 != null)
                            {
                                //  obakejanai2��̃X�N���v�g�ւ̎Q�Ƃ��擾
                                Move move = obakejanai2.GetComponent<Move>();
                                if (move != null)
                                {
                                    //  move��moveFlagTrigger���Ăяo��
                                    move.moveFlagTrigger();
                                    move.ChangeLimit(playTimer);
                                    waitTime = fluctuateNum;
                                }
                            }
                        }
                        else
                        {
                            if (obake2 != null)
                            {
                                //  obake2��̃X�N���v�g�ւ̎Q�Ƃ��擾
                                Move move = obake2.GetComponent<Move>();
                                if (move != null)
                                {
                                    //  move��moveFlagTrigger���Ăяo��
                                    move.moveFlagTrigger();
                                    move.ChangeLimit(playTimer);
                                    waitTime = fluctuateNum;
                                }
                            }
                        }

                        break;

                    case 2:
                        ProbabilityMachine();
                        if (!probabilityFlag)
                        {
                            if (obakejanai3 != null)
                            {
                                //  obakejanai3��̃X�N���v�g�ւ̎Q�Ƃ��擾
                                Move move = obakejanai3.GetComponent<Move>();
                                if (move != null)
                                {
                                    //  move��moveFlagTrigger���Ăяo��
                                    move.moveFlagTrigger();
                                    move.ChangeLimit(playTimer);
                                    waitTime = fluctuateNum;
                                }
                            }
                        }
                        else
                        {
                            if (obake3 != null)
                            {
                                //  obake3��̃X�N���v�g�ւ̎Q�Ƃ��擾
                                Move move = obake3.GetComponent<Move>();
                                if (move != null)
                                {
                                    //  move��moveFlagTrigger���Ăяo��
                                    move.moveFlagTrigger();
                                    move.ChangeLimit(playTimer);
                                    waitTime = fluctuateNum;
                                }
                            }
                        }

                        break;
                    case 3:
                        ProbabilityMachine();
                        if (!probabilityFlag)
                        {
                            if (obakejanai4 != null)
                            {
                                //  obakejanai4��̃X�N���v�g�ւ̎Q�Ƃ��擾
                                Move move = obakejanai4.GetComponent<Move>();
                                if (move != null)
                                {
                                    //  move��moveFlagTrigger���Ăяo��
                                    move.moveFlagTrigger();
                                    move.ChangeLimit(playTimer);
                                    waitTime = fluctuateNum;
                                }
                            }
                        }
                        else
                        {
                            if (obake4 != null)
                            {
                                //  obake4��̃X�N���v�g�ւ̎Q�Ƃ��擾
                                Move move = obake4.GetComponent<Move>();
                                if (move != null)
                                {
                                    //  move��moveFlagTrigger���Ăяo��
                                    move.moveFlagTrigger();
                                    move.ChangeLimit(playTimer);
                                    waitTime = fluctuateNum;
                                }
                            }
                        }

                        break;
                    case 4:
                        ProbabilityMachine();
                        if (!probabilityFlag)
                        {
                            if (obakejanai5 != null)
                            {
                                //  obakejanai5��̃X�N���v�g�ւ̎Q�Ƃ��擾
                                Move move = obakejanai5.GetComponent<Move>();
                                if (move != null)
                                {
                                    //  move��moveFlagTrigger���Ăяo��
                                    move.moveFlagTrigger();
                                    move.ChangeLimit(playTimer);
                                    waitTime = fluctuateNum;
                                }
                            }
                        }
                        else
                        {
                            if (obake5 != null)
                            {
                                //  obake5��̃X�N���v�g�ւ̎Q�Ƃ��擾
                                Move move = obake5.GetComponent<Move>();
                                if (move != null)
                                {
                                    //  move��moveFlagTrigger���Ăяo��
                                    move.moveFlagTrigger();
                                    move.ChangeLimit(playTimer);
                                    waitTime = fluctuateNum;
                                }
                            }
                        }
                        break;
                    case 5:
                        ProbabilityMachine();
                        if (!probabilityFlag)
                        {
                            if (obakejanai6 != null)
                            {
                                //  obakejanai6��̃X�N���v�g�ւ̎Q�Ƃ��擾
                                Move move = obakejanai6.GetComponent<Move>();
                                if (move != null)
                                {
                                    //  move��moveFlagTrigger���Ăяo��
                                    move.moveFlagTrigger();
                                    move.ChangeLimit(playTimer);
                                    waitTime = fluctuateNum;
                                }
                            }
                        }
                        else
                        {
                            if (obake6 != null)
                            {
                                //  obake6��̃X�N���v�g�ւ̎Q�Ƃ��擾
                                Move move = obake6.GetComponent<Move>();
                                if (move != null)
                                {
                                    //  move��moveFlagTrigger���Ăяo��
                                    move.moveFlagTrigger();
                                    move.ChangeLimit(playTimer);
                                    waitTime = fluctuateNum;
                                }
                            }
                        }
                        break;
                    case 6:
                        ProbabilityMachine();
                        if (!probabilityFlag)
                        {
                            if (obakejanai7 != null)
                            {
                                //  obakejanai7��̃X�N���v�g�ւ̎Q�Ƃ��擾
                                Move move = obakejanai7.GetComponent<Move>();
                                if (move != null)
                                {
                                    //  move��moveFlagTrigger���Ăяo��
                                    move.moveFlagTrigger();
                                    move.ChangeLimit(playTimer);
                                    waitTime = fluctuateNum;
                                }
                            }
                        }
                        else
                        {
                            if (obake7 != null)
                            {
                                //  obake7��̃X�N���v�g�ւ̎Q�Ƃ��擾
                                Move move = obake7.GetComponent<Move>();
                                if (move != null)
                                {
                                    //  move��moveFlagTrigger���Ăяo��
                                    move.moveFlagTrigger();
                                    move.ChangeLimit(playTimer);
                                    waitTime = fluctuateNum;
                                }
                            }
                        }
                        break;
                    case 7:
                        if (bombObject != null)
                        {
                            //  obake7��̃X�N���v�g�ւ̎Q�Ƃ��擾
                            Bomb bomb = bombObject.GetComponent<Bomb>();
                            if (bomb != null)
                            {
                                //  move��moveFlagTrigger���Ăяo��
                                bomb.moveFlagTrigger();
                                bomb.ChangeLimit(playTimer);
                                waitTime = fluctuateNum;
                            }
                        }
                        break;
                }
            }
        }
    }

    void Shuffle()
    {
        randomNo = Random.Range(0, 8);
        Debug.Log(randomNo);
    }

    void ProbabilityMachine()
    {
        int x = Random.Range(0, 5);
        //  5��4��������a�����Ⴂ���Ȃ����΂����o��������
        if (x >= 4)
        {
            probabilityFlag = false;
        }
        else
        {
            probabilityFlag = true;
        }
    }
}

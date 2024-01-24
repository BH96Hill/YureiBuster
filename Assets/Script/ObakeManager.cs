using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectObake : MonoBehaviour
{
    //  ���΂��̎�ނ̗���
    int randomNo;
    int probabilityNo;
    int probabilityNoMin=2;
    int probabilityNoMax=11;
    //  �a���Ă������΂��Ǝa�����Ⴂ���Ȃ����΂��̊m��
    bool probabilityFlag;
    //  ���΂������݂ɏo�鎞��
    float waitTime;

    //  �v���C����
    public float playTimer;

    //  ���E���h���Ƃɑҋ@���Ԃ�ς���
    float fluctuateNum;
    int bombCheck = 0;

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

        GameObject bombObject1 = GameObject.Find("bombObject1");
        GameObject bombObject2 = GameObject.Find("bombObject2");
        GameObject bombObject3 = GameObject.Find("bombObject3");
        GameObject bombObject4 = GameObject.Find("bombObject4");
        GameObject bombObject5 = GameObject.Find("bombObject5");
        GameObject bombObject6 = GameObject.Find("bombObject6");
        GameObject bombObject7 = GameObject.Find("bombObject7");


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
            probabilityNoMin = 0;
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
                        ProbabilityMachine(probabilityNoMin,probabilityNoMax);
                        if (probabilityNo >= 8 && probabilityNo < 11)
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
                        else if (probabilityNo <= 7 && probabilityNo > 1)
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
                        else
                        {
                            if (bombObject1 != null)
                            {
                                if (bombCheck > 3)
                                {
                                    //  bomb��̃X�N���v�g�ւ̎Q�Ƃ��擾
                                    Bomb bomb = bombObject1.GetComponent<Bomb>();
                                    if (bomb != null)
                                    {
                                        //  move��moveFlagTrigger���Ăяo��
                                        bomb.moveFlagTrigger();
                                        bomb.ChangeLimit(playTimer);
                                        bombCheck++;
                                        waitTime = fluctuateNum;

                                    }
                                }
                                if (bombCheck == 3)
                                {
                                    Destroy(bombObject1);
                                }
                            }
                        }

                        break;

                    case 1:
                        ProbabilityMachine(probabilityNoMin, probabilityNoMax);
                        if (probabilityNo >= 8 && probabilityNo < 11)
                        {
                            if (obakejanai2 != null)
                            {
                                //  obake3��̃X�N���v�g�ւ̎Q�Ƃ��擾
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
                        else if (probabilityNo <= 7 && probabilityNo > 1)
                        {
                            if (obake2 != null)
                            {
                                //  obake1��̃X�N���v�g�ւ̎Q�Ƃ��擾
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
                        else
                        {
                            if (bombObject2 != null)
                            {
                                if (bombCheck < 3)
                                {
                                    //  bomb��̃X�N���v�g�ւ̎Q�Ƃ��擾
                                    Bomb bomb = bombObject2.GetComponent<Bomb>();
                                    if (bomb != null)
                                    {
                                        //  move��moveFlagTrigger���Ăяo��
                                        bomb.moveFlagTrigger();
                                        bomb.ChangeLimit(playTimer);
                                        bombCheck++;
                                        waitTime = fluctuateNum;

                                    }
                                }
                                if (bombCheck == 3)
                                {
                                    Destroy(bombObject2);
                                }
                            }
                        }

                        break;

                    case 2:
                        ProbabilityMachine(probabilityNoMin, probabilityNoMax);
                        if (probabilityNo >= 8 && probabilityNo < 11)
                        {
                            if (obakejanai3 != null)
                            {
                                //  obake3��̃X�N���v�g�ւ̎Q�Ƃ��擾
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
                        else if (probabilityNo <= 7 && probabilityNo > 1)
                        {
                            if (obake3 != null)
                            {
                                //  obake1��̃X�N���v�g�ւ̎Q�Ƃ��擾
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
                        else
                        {
                            if (bombObject3 != null)
                            {
                                if (bombCheck < 3)
                                {
                                    //  bomb��̃X�N���v�g�ւ̎Q�Ƃ��擾
                                    Bomb bomb = bombObject3.GetComponent<Bomb>();
                                    if (bomb != null)
                                    {
                                        //  move��moveFlagTrigger���Ăяo��
                                        bomb.moveFlagTrigger();
                                        bomb.ChangeLimit(playTimer);
                                        bombCheck++;
                                        waitTime = fluctuateNum;

                                    }
                                }
                                if (bombCheck == 3)
                                {
                                    Destroy(bombObject3);
                                }
                            }
                        }

                        break;
                    case 3:
                        ProbabilityMachine(probabilityNoMin, probabilityNoMax);
                        if (probabilityNo >= 8 && probabilityNo < 11)
                        {
                            if (obakejanai4 != null)
                            {
                                //  obake3��̃X�N���v�g�ւ̎Q�Ƃ��擾
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
                        else if (probabilityNo <= 7 && probabilityNo > 1)
                        {
                            if (obake4 != null)
                            {
                                //  obake1��̃X�N���v�g�ւ̎Q�Ƃ��擾
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
                        else
                        {
                            if (bombObject4 != null)
                            {
                                if (bombCheck < 3)
                                {
                                    //  bomb��̃X�N���v�g�ւ̎Q�Ƃ��擾
                                    Bomb bomb = bombObject4.GetComponent<Bomb>();
                                    if (bomb != null)
                                    {
                                        //  move��moveFlagTrigger���Ăяo��
                                        bomb.moveFlagTrigger();
                                        bomb.ChangeLimit(playTimer);
                                        bombCheck++;
                                        waitTime = fluctuateNum;

                                    }
                                }
                                if (bombCheck == 3)
                                {
                                    Destroy(bombObject4);
                                }
                            }
                        }

                        break;
                    case 4:
                        ProbabilityMachine(probabilityNoMin, probabilityNoMax);
                        if (probabilityNo >= 8 && probabilityNo < 11)
                        {
                            if (obakejanai5 != null)
                            {
                                //  obake3��̃X�N���v�g�ւ̎Q�Ƃ��擾
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
                        else if (probabilityNo <= 7 && probabilityNo > 1)
                        {
                            if (obake5 != null)
                            {
                                //  obake1��̃X�N���v�g�ւ̎Q�Ƃ��擾
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
                        else
                        {
                            if (bombObject5 != null)
                            {
                                if (bombCheck < 3)
                                {
                                    //  bomb��̃X�N���v�g�ւ̎Q�Ƃ��擾
                                    Bomb bomb = bombObject5.GetComponent<Bomb>();
                                    if (bomb != null)
                                    {
                                        //  move��moveFlagTrigger���Ăяo��
                                        bomb.moveFlagTrigger();
                                        bomb.ChangeLimit(playTimer);
                                        bombCheck++;
                                        waitTime = fluctuateNum;

                                    }
                                }
                                if (bombCheck == 3)
                                {
                                    Destroy(bombObject5);
                                }
                            }
                        }

                        break;
                    case 5:
                        ProbabilityMachine(probabilityNoMin, probabilityNoMax);
                        if (probabilityNo >= 8 && probabilityNo < 11)
                        {
                            if (obakejanai6 != null)
                            {
                                //  obake3��̃X�N���v�g�ւ̎Q�Ƃ��擾
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
                        else if (probabilityNo <= 7 && probabilityNo > 1)
                        {
                            if (obake6 != null)
                            {
                                //  obake1��̃X�N���v�g�ւ̎Q�Ƃ��擾
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
                        else
                        {
                            if (bombObject6 != null)
                            {
                                if (bombCheck < 3)
                                {
                                    //  bomb��̃X�N���v�g�ւ̎Q�Ƃ��擾
                                    Bomb bomb = bombObject6.GetComponent<Bomb>();
                                    if (bomb != null)
                                    {
                                        //  move��moveFlagTrigger���Ăяo��
                                        bomb.moveFlagTrigger();
                                        bomb.ChangeLimit(playTimer);
                                        bombCheck++;
                                        waitTime = fluctuateNum;

                                    }
                                }
                                if (bombCheck == 3)
                                {
                                    Destroy(bombObject6);
                                }
                            }
                        }

                        break;
                    case 6:
                        ProbabilityMachine(probabilityNoMin, probabilityNoMax);
                        if (probabilityNo >= 8 && probabilityNo < 11)
                        {
                            if (obakejanai7 != null)
                            {
                                //  obake3��̃X�N���v�g�ւ̎Q�Ƃ��擾
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
                        else if (probabilityNo <= 7 && probabilityNo > 1)
                        {
                            if (obake7 != null)
                            {
                                //  obake1��̃X�N���v�g�ւ̎Q�Ƃ��擾
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
                        else
                        {
                            if (bombObject7 != null)
                            {
                                if (bombCheck < 3)
                                {
                                    //  bomb��̃X�N���v�g�ւ̎Q�Ƃ��擾
                                    Bomb bomb = bombObject7.GetComponent<Bomb>();
                                    if (bomb != null)
                                    {
                                        //  move��moveFlagTrigger���Ăяo��
                                        bomb.moveFlagTrigger();
                                        bomb.ChangeLimit(playTimer);
                                        bombCheck++;
                                        waitTime = fluctuateNum;

                                    }
                                }
                                if(bombCheck==3)
                                {
                                    Destroy(bombObject7);
                                }
                            }
                        }

                        break;
                }
            }
        }
    }

    void Shuffle()
    {
        randomNo = Random.Range(0, 7);
        Debug.Log(randomNo);
    }

    void ProbabilityMachine(int min,int max)
    {
        probabilityNo = Random.Range(min, max);
        Debug.Log(probabilityNo);
    }
}

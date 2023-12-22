using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Move : MonoBehaviour
{
    public float nowPosi;

    bool backTrigger;
    bool moveFlag;
    bool respawnFlag;

    //  前で待機する時間
    private float limit;

    //  変わる待機時間
    float fluctuateWaitTimer;
    float fluctuateSpped;
    Vector3 originalPos;

    float top;

    float bottom;

    float exchange = 0.03f;

    //経過時間
    //private bool respawnFlag;

    private void Start()
    {
        //respawnFlag=false;
        limit = 2.0f;
        backTrigger = false;
        moveFlag = false;
        nowPosi = this.transform.position.y;

        top = gameObject.transform.position.y + 0.3f;
        bottom = gameObject.transform.position.y - 0.3f;
        originalPos = transform.position;
    }
    void Update()
    {
        if (moveFlag)
        {
            if (gameObject.transform.position.y > top)
            {
                exchange = -0.0005f;
            }

            if (gameObject.transform.position.y < bottom)
            {
                exchange = 0.0005f;
            }

            gameObject.transform.Translate(0, exchange, 0);

            if (backTrigger == false)
            {
                transform.position += transform.TransformDirection(Vector3.forward) * fluctuateSpped * Time.deltaTime;
            }
            else
            {
                limit -= Time.deltaTime;
                if (limit < 0.0f)
                {
                    transform.position += transform.TransformDirection(Vector3.back) * fluctuateSpped * Time.deltaTime;
                }
                else
                {
                    transform.position += transform.TransformDirection(Vector3.forward) * 0f * Time.deltaTime;
                }
            }
        }
        else
        {
            transform.position += transform.TransformDirection(Vector3.forward) * 0f * Time.deltaTime;
        }

        if(respawnFlag)
        {
            float timer = 0.5f;
            while (timer <= 0.0f)
            {
                
                timer -= Time.deltaTime;
            }
            gameObject.transform.position = originalPos;
            respawnFlag = false;
        }

    }

    public void ChangeLimit(float time)
    {
        if (time <= 60.0f && time > 40.0f)
        {
            fluctuateWaitTimer = 2.0f;
            fluctuateSpped = 5.5f;
        }
        if (time <= 40.0f && time > 20.0f)
        {
            fluctuateWaitTimer = 1.25f;
            fluctuateSpped = 6.5f;
        }
        if (time <= 20.0f && time > 0.0f)
        {
            fluctuateWaitTimer = 0.5f;
            fluctuateSpped = 7.5f;
        }
    }

    public void moveFlagTrigger()
    {
        moveFlag = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        string yourTag = other.gameObject.tag;
        if (yourTag == "PlayerCollider")
        {
            limit = fluctuateWaitTimer;
            backTrigger = true;
        }
        if (yourTag == "Respawn")
        {
            backTrigger = false;
            moveFlag = false;
            gameObject.SetActive(true);
        }
        if (yourTag == "Sword"||yourTag=="BombRadius")
        {   
            backTrigger = false;
            respawnFlag = true;
        }

    }

}



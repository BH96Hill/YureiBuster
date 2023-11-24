using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitController : MonoBehaviour
{
    //当たり判定メソッド
   

    private void OnTriggerEnter(Collider other)
    {
        //衝突したオブジェクトがBullet(大砲の弾)だったとき
        if (other.gameObject.CompareTag("Ground"))
        {
            //敵(スクリプトがアタッチされているオブジェクト自身)を削除
            Destroy(gameObject,3);
        }
    }
}


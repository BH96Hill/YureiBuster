using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyObject : MonoBehaviour
{

    bool isFirst = true; // 最初の一回を判定するフラグ

    void FixedUpdate()
    {
        // 一回だけ呼ばれる
        if (isFirst)
        {
            isFirst = false;  // 一回はすぎた
            Rigidbody rb = this.GetComponent<Rigidbody>();  // rigidbodyを取得
            Vector3 force = new Vector3(0.0f, 5.0f, 0.0f);  // 力を設定
            rb.AddForce(force, ForceMode.Impulse);          // 力を加える
        }
    }
}
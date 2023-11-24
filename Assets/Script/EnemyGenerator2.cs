//https://xr-hub.com/archives/16386

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator2 : MonoBehaviour
{
    //敵プレハブ
    public GameObject enemyPrefab;
    //時間間隔の最小値
    public float minTime = 2f;
    //時間間隔の最大値
    public float maxTime = 5f;
    //X座標の最小値
    public float xMinPosition = -2.0f;
    //X座標の最大値
    public float xMaxPosition = 2f;
    //Y座標の最小値
    public float yMinPosition = 0f;
    //Y座標の最大値
    public float yMaxPosition = 5f;
    //Z座標の最小値
    public float zMinPosition = -2f;
    //Z座標の最大値
    public float zMaxPosition = 2f;
    //敵生成時間間隔
    private float interval;
    //経過時間
    private float time = 0f;

    // Start is called before the first frame update
    void Start()
    {
        //時間間隔を決定する
        interval = GetRandomTime();
    }

    // Update is called once per frame
    void Update()
    {
        //時間計測
        time += Time.deltaTime;

        //経過時間が生成時間になったとき(生成時間より大きくなったとき)
        if (time > interval)
        {
            //enemyをインスタンス化する(生成する)
            GameObject enemy = Instantiate(enemyPrefab);
            enemy.transform.position = GetRandomPosition();
            //経過時間を初期化して再度時間計測を始める
            time = 0f;
            //次に発生する時間間隔を決定する
            interval = GetRandomTime();
        }
    }
    //ランダムな時間を生成する関数
    private float GetRandomTime()
    {
        return Random.Range(minTime, maxTime);
    }

    //ランダムな位置を生成する関数
    private Vector3 GetRandomPosition()
    {
        //それぞれの座標をランダムに生成する
        float x = Random.Range(xMinPosition, xMaxPosition);
        float y = Random.Range(yMinPosition, yMaxPosition);
        float z = Random.Range(zMinPosition, zMaxPosition);

        //Vector3型のPositionを返す
        return new Vector3(x, y, z);
    }
}
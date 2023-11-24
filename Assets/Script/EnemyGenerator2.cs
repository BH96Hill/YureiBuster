//https://xr-hub.com/archives/16386

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator2 : MonoBehaviour
{
    //�G�v���n�u
    public GameObject enemyPrefab;
    //���ԊԊu�̍ŏ��l
    public float minTime = 2f;
    //���ԊԊu�̍ő�l
    public float maxTime = 5f;
    //X���W�̍ŏ��l
    public float xMinPosition = -2.0f;
    //X���W�̍ő�l
    public float xMaxPosition = 2f;
    //Y���W�̍ŏ��l
    public float yMinPosition = 0f;
    //Y���W�̍ő�l
    public float yMaxPosition = 5f;
    //Z���W�̍ŏ��l
    public float zMinPosition = -2f;
    //Z���W�̍ő�l
    public float zMaxPosition = 2f;
    //�G�������ԊԊu
    private float interval;
    //�o�ߎ���
    private float time = 0f;

    // Start is called before the first frame update
    void Start()
    {
        //���ԊԊu�����肷��
        interval = GetRandomTime();
    }

    // Update is called once per frame
    void Update()
    {
        //���Ԍv��
        time += Time.deltaTime;

        //�o�ߎ��Ԃ��������ԂɂȂ����Ƃ�(�������Ԃ��傫���Ȃ����Ƃ�)
        if (time > interval)
        {
            //enemy���C���X�^���X������(��������)
            GameObject enemy = Instantiate(enemyPrefab);
            enemy.transform.position = GetRandomPosition();
            //�o�ߎ��Ԃ����������čēx���Ԍv�����n�߂�
            time = 0f;
            //���ɔ������鎞�ԊԊu�����肷��
            interval = GetRandomTime();
        }
    }
    //�����_���Ȏ��Ԃ𐶐�����֐�
    private float GetRandomTime()
    {
        return Random.Range(minTime, maxTime);
    }

    //�����_���Ȉʒu�𐶐�����֐�
    private Vector3 GetRandomPosition()
    {
        //���ꂼ��̍��W�������_���ɐ�������
        float x = Random.Range(xMinPosition, xMaxPosition);
        float y = Random.Range(yMinPosition, yMaxPosition);
        float z = Random.Range(zMinPosition, zMaxPosition);

        //Vector3�^��Position��Ԃ�
        return new Vector3(x, y, z);
    }
}
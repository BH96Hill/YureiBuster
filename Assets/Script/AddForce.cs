using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyObject : MonoBehaviour
{

    bool isFirst = true; // �ŏ��̈��𔻒肷��t���O

    void FixedUpdate()
    {
        // ��񂾂��Ă΂��
        if (isFirst)
        {
            isFirst = false;  // ���͂�����
            Rigidbody rb = this.GetComponent<Rigidbody>();  // rigidbody���擾
            Vector3 force = new Vector3(0.0f, 5.0f, 0.0f);  // �͂�ݒ�
            rb.AddForce(force, ForceMode.Impulse);          // �͂�������
        }
    }
}
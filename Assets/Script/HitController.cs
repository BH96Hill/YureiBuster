using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitController : MonoBehaviour
{
    //�����蔻�胁�\�b�h
   

    private void OnTriggerEnter(Collider other)
    {
        //�Փ˂����I�u�W�F�N�g��Bullet(��C�̒e)�������Ƃ�
        if (other.gameObject.CompareTag("Ground"))
        {
            //�G(�X�N���v�g���A�^�b�`����Ă���I�u�W�F�N�g���g)���폜
            Destroy(gameObject,3);
        }
    }
}


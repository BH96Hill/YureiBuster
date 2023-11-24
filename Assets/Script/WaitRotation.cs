using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//NavMeshAgent�g���Ƃ��ɕK�v
using UnityEngine.AI;

//�I�u�W�F�N�g��NavMeshAgent�R���|�[�l���g��ݒu
[RequireComponent(typeof(NavMeshAgent))]

public class WaitRotation : MonoBehaviour
{
    public Transform central;

    public float nowPosi;

    private NavMeshAgent agent;
    [SerializeField] float radius = 3;
    [SerializeField] float waitTime = 5;
    [SerializeField] float time = 0;

    Vector3 pos;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        agent.autoBraking = false;
        //NavMeshAgent�ŉ�]�����Ȃ��悤�ɂ���
        agent.updateRotation = false;

        GotoNextPoint();
    }
    void GotoNextPoint()
    {
        agent.isStopped = false;
        float posX = Random.Range(-1 * radius, radius);
        float posZ = Random.Range(-1 * radius, radius);

        pos = central.position;
        pos.x += posX;
        pos.z += posZ;

        //Y�������ύX���Ȃ��ڕW�n�_
        Vector3 direction = new Vector3(pos.x, transform.position.y, pos.z);

        //Y�������ύX���Ȃ��ڕW�n�_���猻�ݒn�������Č���������o��
        Quaternion rotation =
            Quaternion.LookRotation(direction - transform.position, Vector3.up);
        //���̃I�u�W�F�N�g�̌�����ւ���
        transform.rotation = rotation;

        agent.destination = pos;
    }

    void StopHere()
    {
        agent.isStopped = true;
        time += Time.deltaTime;

        if (time > waitTime)
        {
            GotoNextPoint();
            time = 0;
        }
    }

    void Update()
    {
        if (!agent.pathPending && agent.remainingDistance < 0.5f)
            StopHere();

        transform.position = new Vector3(transform.position.x, nowPosi + Mathf.PingPong(Time.time/3, 0.3f), transform.position.z);
    }
}
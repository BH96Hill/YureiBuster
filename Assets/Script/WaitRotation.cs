using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//NavMeshAgent使うときに必要
using UnityEngine.AI;

//オブジェクトにNavMeshAgentコンポーネントを設置
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
        //NavMeshAgentで回転をしないようにする
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

        //Y軸だけ変更しない目標地点
        Vector3 direction = new Vector3(pos.x, transform.position.y, pos.z);

        //Y軸だけ変更しない目標地点から現在地を引いて向きを割り出す
        Quaternion rotation =
            Quaternion.LookRotation(direction - transform.position, Vector3.up);
        //このオブジェクトの向きを替える
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